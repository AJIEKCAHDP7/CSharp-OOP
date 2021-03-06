// 1. ООП. Отношения между классами и объектами.
// 1.2. Реализация


/* Реализация предполагает определение интерфейса и его реализация в классах.
 * Например, имеется интерфейс IMovable с методом Move, который реализуется в классе Car.
 */

// Создание публичного интерфейса IMovable с не реализованным методом Move().
public interface IMovable
{
	void Move();
}

// Наследование от интерфейса и реализация его метода Move() в классе Car
/* 
 * Если класс применяет интерфейс, то этот класс должен реализовать все методы и свойства интерфейса, 
 * которые не имеют реализации по умолчанию.
 */
public class Car : IMoveble
{
    // Реализация метода интерфейса
	public void Move()
    {
        Console.WriteLine("Car rides...");
    }
}
