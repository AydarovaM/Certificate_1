# Описание решения задачи для Certificate_1
## Пошаговое решение
### Условие
*  Задаем рабочий массив items;
*  Создаем новый пустой массив new_items;
*  Размер пустого массива равен 0;
### Цикл

*  Начинаем с элемента по индексу [0]. До тех пор пока индекс элемента будет меньше длины массива, перебираем элементы один за другим. В ином случае, выходим из цикла;

* Ищем элементы рабочего массива, длина которых <= 3. 

* Чтобы определить длину нового массива, будем считать найденные элементы. 

* Каждый новый найденный элемент, будет увеличивать размер массива на 1.

* А индекс каждого нового найденного элемента в новом массиве будет на единицу меньше найденной на тот момент длины массива. Записываем найденный элемент в новый массив по индексу последнего элемента(возвращаемся к началу цикла);

### Выводим на печать новый массив
*  Открывается скоба;
*  Печатается каждый найденный элемент нового массива, начиная с [0];
*  До тех пор, пока индекс элемента не равен последнему индексу массива, то после элемента печатается запятая и пробел;
*  Закрывается скоба;

### Блок-схема
* ![Block scheme](/PrintScreen%20Certificate_1.jpg)






