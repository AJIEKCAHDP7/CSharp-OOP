// 1. ООП. Отношения между классами и объектами.
// 1.5. Агрегация

/* 
 * От композиции следует отличать агрегацию. 
 * Она также предполагает отношение HAS A, но реализуется она иначе.
 */

public abstract class Engine
{ 

}

/*
* При агрегации реализуется слабая связь, то есть в данном случае объекты Car и Engine будут равноправны.
* В конструктор Car передается ссылка на уже имеющийся объект Engine.
* И, как правило, определяется ссылка не на конкретный класс, а на абстрактный класс или интерфейс, что увеличивает гибкость программы.
*/
public class Car
{
	Engine engine;

	public Car(Engine eng)
	{
		engine = eng;
	}
}
