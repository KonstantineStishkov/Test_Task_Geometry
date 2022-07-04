namespace Geometry
{
    public abstract class Shape
    {
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <param name="precision">Точность передается, как число знаков после запятой в диапазоне от 0 до 15 включительно</param>
        /// <returns></returns>
        public abstract double GetArea(int precision);
    }
}