using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        #region -Variabled-
        const float startTemperature = 15;

        // Timer logic
        readonly Timer timer = new Timer();

        int cycleCount = 0;
        const int cycleCountTotal = 15;
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        // Функция по началу процесса изменения температуры и скорости вращения вентилятора
        private void StartMeasurementProcess()
        {
            // Получение текущей температуры
            float temperature = startTemperature + (float)(1.0 * cycleCount);

            /* -- Обновление графиков и значений -- */
            textBoxT.Text = temperature.ToString();
            chartT.Series[0].Points.AddXY(cycleCount + 1, temperature);
            /* -- ------------------------------ -- */

            // Получение начальных нечетких множеств
            float[,,] tSet = GetStandartTSet();
            float[,,] vSet = GetStandartVSet();

            /* -- Обновление графиков и значений -- */
            chartTSet.Series[0].Points.Clear();
            chartVSet.Series[0].Points.Clear();

            for (int j = 0; j < tSet.GetLength(0); j++)
            {
                for (int k = 0; k < tSet.GetLength(2); k++)
                {
                    chartTSet.Series[0].Points.AddXY(tSet[j, 0, k], tSet[j, 1, k]);
                    chartVSet.Series[0].Points.AddXY(vSet[j, 0, k], vSet[j, 1, k]);
                }
            }
            /* -- ------------------------------ -- */

            // Получение текущих значений функции принадлежности
            float[] belongingFunctionValues = GetBelongingFunctionValues(temperature, tSet);

            // Получение модифицированного нечеткого множества путём "умножения"
            vSet = GetModifiedVSet(vSet, belongingFunctionValues);

            // Получение центра тяжести суперпозиции
            float[] centerSuperpositionWeight = GetCenterSuperpositionWeight(vSet);

            // Вычисление текущей скорости вращения вентилятора
            float speed = centerSuperpositionWeight[0];

            /* -- Обновление графиков и значений -- */
            textBoxX.Text = centerSuperpositionWeight[0].ToString();
            textBoxY.Text = centerSuperpositionWeight[1].ToString();
            
            textBoxV.Text = speed.ToString();
            chartV.Series[0].Points.AddXY(temperature, speed);
            /* -- ------------------------------ -- */
        }

        // Функция по получению стандартного нечеткого множества T
        private float[,,] GetStandartTSet()
        {
            float[,,] set = new float[,,]
            {
                // Множество "Низкая"
                { { 0, 10, 20 }, { 1, 1, 0 } },
                // Множество "Средняя"
                { { 10, 20, 30 }, { 0, 1, 0 } },
                // Множество "Высокая"
                { { 20, 30, 100 }, { 0, 1, 1 } }
            };


            return set;
        }

        // Функция по получению стандартного нечеткого множества V
        private float[,,] GetStandartVSet()
        {
            float[,,] set = new float[,,]
            {
                // Множество "Низкая"
                { { 0, 200, 400 }, { 1, 1, 0 } },
                // Множество "Средняя"
                { { 200, 400, 600 }, { 0, 1, 0 } },
                // Множество "Высокая"
                { { 400, 600, 1000 }, { 0, 1, 1 } }
            };


            return set;
        }

        // Функция по получению модифицированного нечеткого множества V
        private float[,,] GetModifiedVSet(float[,,] vSet, float[] belongingFunctionValues)
        {
            float[,,] newSet = new float[vSet.GetLength(0), vSet.GetLength(1), vSet.GetLength(2)];

            for (int i = 0; i < vSet.GetLength(0); i++)
            {
                for (int j = 0; j < vSet.GetLength(2); j++)
                {
                    newSet[i, 0, j] = vSet[i, 0, j];
                    newSet[i, 1, j] = vSet[i, 1, j] * belongingFunctionValues[i];
                }
            }

            return newSet;
        }

        // Функция по получению значений на отрезке прямой
        private float GettingValueOnLine(float x, float x1, float x2, float y1, float y2)
        {
            // Y = (Y1 - Y2)/(X1 - X2) * K + Y2
            // K = X - X2 Or K = X1 - X
            return (float)(y1 - y2) / (x1 - x2) * (x - x2) + y2;
        }

        // Функция по получению значений функции принадлежности
        private float[] GetBelongingFunctionValues(float temperature, float[,,] tSet)
        {
            float[] result = new float[3];

            // Множество "Низкая"
            if (temperature <= tSet[0, 0, 1]) result[0] = tSet[0, 1, 1];
            else if (temperature <= tSet[0, 0, 2]) result[0] = GettingValueOnLine(temperature, tSet[0, 0, 1], tSet[0, 0, 2], tSet[0, 1, 1], tSet[0, 1, 2]);
            else result[0] = 0;

            // Множество "Средняя"
            if (temperature == tSet[1, 0, 1]) result[1] = tSet[1, 1, 1];
            else if (temperature >= tSet[1, 0, 0] && temperature < tSet[1, 0, 1]) result[1] = GettingValueOnLine(temperature, tSet[1, 0, 0], tSet[1, 0, 1], tSet[1, 1, 0], tSet[1, 1, 1]);
            else if (temperature > tSet[1, 0, 1] && temperature <= tSet[1, 0, 2]) result[1] = GettingValueOnLine(temperature, tSet[1, 0, 1], tSet[1, 0, 2], tSet[1, 1, 1], tSet[1, 1, 2]);
            else result[1] = 0;

            // Множество "Высокая"
            if (temperature >= tSet[2, 0, 1]) result[2] = tSet[2, 1, 1];
            else if (temperature >= tSet[2, 0, 0]) result[2] = GettingValueOnLine(temperature, tSet[2, 0, 0], tSet[2, 0, 1], tSet[2, 1, 0], tSet[2, 1, 1]);
            else result[2] = 0;

            return result;
        }

        // Функция по проверки значений массива на пустоту (равность 0)
        private bool IsArrayValuesEqualsZero(float[,,] array, int i, int j)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] != 0) return false;
            }

            return true;
        }

        // Функция по получению координат точек фигур
        private float[,,] GetFiguresCoordinates(float[,,] vSet)
        {
            float[,,] result = new float[3, 2, 3];

            bool isFirstFigureEmpty = IsArrayValuesEqualsZero(vSet, 0, 1);
            bool isSecondFigureEmpty = IsArrayValuesEqualsZero(vSet, 1, 1);
            bool isThirdFigureEmpty = IsArrayValuesEqualsZero(vSet, 2, 1);

            // Одна фигура - треугольник по центру
            if (isFirstFigureEmpty && isThirdFigureEmpty)
            {
                for (int i = 0; i < vSet.GetLength(1); i++)
                {
                    for (int j = 0; j < vSet.GetLength(2); j++)
                    {
                        result[1, i, j] = vSet[1, i, j];
                    }
                }
            }
            // Две фигуры - крайний прямоугольник
            else if (
                isSecondFigureEmpty
                && (
                (isFirstFigureEmpty && !isThirdFigureEmpty)
                || (!isFirstFigureEmpty && isThirdFigureEmpty)
                )
            )
            {
                // Получение информации о том, какой именно из прямоугольников
                int i = isFirstFigureEmpty ? 2 : 0;

                // Координаты крайнего прямоугольника
                for (int j = 0; j < vSet.GetLength(1); j++)
                {
                    for (int k = 0; k < vSet.GetLength(2); k++)
                    {
                        result[i, j, k] = vSet[i, j, k];
                    }
                }
            }
            // Три фигуры - крайний прямоугольник и центраильный треугольник (образуют между собой еще один треугольник)
            else
            {
                int i = isFirstFigureEmpty ? 1 : 0;

                // Координаты центрального треугольника и крайнего прямоугольника
                for (; i < vSet.GetLength(0) - (isFirstFigureEmpty ? 0 : 1); i++)
                {
                    for (int j = 0; j < vSet.GetLength(1); j++)
                    {
                        for (int k = 0; k < vSet.GetLength(2); k++)
                        {
                            result[i, j, k] = vSet[i, j, k];
                        }
                    }
                }

                i = isFirstFigureEmpty ? 0 : 2;

                // Координаты треугольника образованного между центральным треугольником и прямоугольником
                result[i, 0, 0] = vSet[1, 0, 2 - i];
                result[i, 1, 0] = vSet[1, 1, 2 - i];

                result[i, 0, 1] = vSet[2 - i, 0, 1];
                result[i, 1, 1] = vSet[2 - i, 1, 1];

                // Вычисление координат неизвестной точки
                result[i, 0, 2] = vSet[1, 1, 1] / vSet[2 - i, 1, 1] * 200 / (1 + (vSet[1, 1, 1] / vSet[2 - i, 1, 1]));
                result[i, 1, 2] = vSet[1, 1, 1] / vSet[2 - i, 1, 1] * vSet[1, 1, 1] / (1 + (vSet[1, 1, 1] / vSet[2 - i, 1, 1]));

                result[i, 0, 2] = isFirstFigureEmpty ? result[i, 0, 2] + vSet[1, 0, 1] : vSet[1, 0, 1] - result[i, 0, 2];
                result[i, 1, 2] = vSet[1, 1, 1] - result[i, 1, 2];
            }

            return result;
        }

        // Функция по получению центра тяжести суперпозиции фигур
        private float[,] GetFiguresCenterSuperpositionWeight(float[,,] coordinates)
        {
            float[,] result = new float[2, 3];

            for (int i = 0; i < result.GetLength(1); i++)
            {
                if (
                    (coordinates[i, 1, 0] == coordinates[i, 1, 1] && coordinates[i, 0, 0] != coordinates[i, 0, 1])
                    || (coordinates[i, 1, 1] == coordinates[i, 1, 2] && coordinates[i, 0, 1] != coordinates[i, 0, 2])
                )
                {
                    result[0, i] = (coordinates[i, 0, 1] + (coordinates[i, 1, 0] == coordinates[i, 1, 1] ? coordinates[i, 0, 0] : coordinates[i, 0, 2])) * 2 / 4;
                    result[1, i] = (coordinates[i, 1, 1] + (coordinates[i, 1, 0] == coordinates[i, 1, 1] ? coordinates[i, 1, 2] : coordinates[i, 1, 0])) * 2 / 4;
                }
                else
                {
                    for (int j = 0; j < coordinates.GetLength(2); j++)
                    {
                        result[0, i] += coordinates[i, 0, j];
                        result[1, i] += coordinates[i, 1, j];
                    }

                    result[0, i] /= 3;
                    result[1, i] /= 3;
                }
            }

            return result;
        }

        // Функция по получению площади фигур
        private float[] GetFiguresSquare(float[,,] coordinates)
        {
            float[] result = new float[3];

            for (int i = 0; i < coordinates.GetLength(0); i++)
            {
                if (
                    (coordinates[i, 1, 0] == coordinates[i, 1, 1] && coordinates[i, 0, 0] != coordinates[i, 0, 1])
                    || (coordinates[i, 1, 1] == coordinates[i, 1, 2] && coordinates[i, 0, 1] != coordinates[i, 0, 2])
                )
                {
                    // Вычисление площади пряммоугольника
                    float a = (coordinates[i, 1, 0] == coordinates[i, 1, 1]) ? coordinates[i, 0, 1] - coordinates[i, 0, 0] : coordinates[i, 0, 2] - coordinates[i, 0, 1];

                    result[i] = a * coordinates[i, 1, 1];
                }
                else
                {
                    // Вычисление площади треугольника
                    float a = coordinates[i, 0, 2] > coordinates[i, 0, 0] ? coordinates[i, 0, 2] - coordinates[i, 0, 0] : coordinates[i, 0, 0] - coordinates[i, 0, 2];

                    result[i] = a * coordinates[i, 1, 1] / 2;
                }
            }

            return result;
        }

        // Функция по получению центра тяжести суперпозиции
        private float[] GetCenterSuperpositionWeight(float[,,] vSet)
        {
            float[] result = new float[2];

            // Получение координат точек фигур
            float[,,] figuresCoordinates  = GetFiguresCoordinates(vSet);

            /* -- Обновление графиков и значений -- */
            chartFigures.Series[0].Points.Clear();
            chartFigures.Series[1].Points.Clear();
            chartFigures.Series[2].Points.Clear();

            for (int i = 0; i < figuresCoordinates.GetLength(0); i++)
            {
                for (int j = 0; j < figuresCoordinates.GetLength(2); j++)
                {
                    chartFigures.Series[i].Points.AddXY(figuresCoordinates[i, 0, j], figuresCoordinates[i, 1, j]);
                }
            }
            /* -- ------------------------------ -- */

            // Получение центра тяжести суперпозиции фигур
            float[,] figuresCenterSuperpositionWeight = GetFiguresCenterSuperpositionWeight(figuresCoordinates);

            // Получение площади фигур
            float[] figuresSquare = GetFiguresSquare(figuresCoordinates);

            /* -- Обновление графиков и значений -- */
            textBoxX1.Text = figuresCenterSuperpositionWeight[0, 0].ToString();
            textBoxX2.Text = figuresCenterSuperpositionWeight[0, 1].ToString();
            textBoxX3.Text = figuresCenterSuperpositionWeight[0, 2].ToString();

            textBoxY1.Text = figuresCenterSuperpositionWeight[1, 0].ToString();
            textBoxY2.Text = figuresCenterSuperpositionWeight[1, 1].ToString();
            textBoxY3.Text = figuresCenterSuperpositionWeight[1, 2].ToString();

            textBoxS1.Text = figuresSquare[0].ToString();
            textBoxS2.Text = figuresSquare[1].ToString();
            textBoxS3.Text = figuresSquare[2].ToString();
            /* -- ------------------------------ -- */

            // Вычисление центра тяжести суперпозиции
            float sumXS = 0;
            float sumYS = 0;
            float sumS = 0;

            for (int i = 0; i < figuresSquare.GetLength(0); i++)
            {
                sumXS += figuresCenterSuperpositionWeight[0, i] * figuresSquare[i];
                sumYS += figuresCenterSuperpositionWeight[1, i] * figuresSquare[i];
                sumS += figuresSquare[i];
            }

            result[0] = sumXS / sumS;
            result[1] = sumYS / sumS;

            return result;
        }

        // Функция по обновлений цикла обработки
        private void ResetCycle()
        {
            cycleCount = 0;

            textBoxT.Text = "0";
            textBoxV.Text = "0";

            chartTSet.Series[0].Points.Clear();
            chartVSet.Series[0].Points.Clear();

            chartFigures.Series[0].Points.Clear();
            chartFigures.Series[1].Points.Clear();
            chartFigures.Series[2].Points.Clear();

            chartT.Series[0].Points.Clear();
            chartV.Series[0].Points.Clear();
        }

        // Функция по запуску процесса расчётов
        private void ButtonStartCalculation_Click(object sender, System.EventArgs e)
        {
            ResetCycle();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        // Функция по запуску процесс расчёта конкретного цикла
        private void Timer_Tick(object sender, System.EventArgs e)
        {
            StartMeasurementProcess();

            cycleCount++;

            if (cycleCount >= cycleCountTotal)
            {
                timer.Stop();
            }
        }
    }
}
