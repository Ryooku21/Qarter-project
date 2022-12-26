### Ссылки

1. [Задание](#задание)
2. [Задача](#задача)
3. [Список файлов проекта](#список-файлов-проекта)
4. [Логика решения](#логика-решения)

# Задание 

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым файлом README.md
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий

___
## Задача

Написать программу, которая из **имеющегося массива** строк формирует **новый массив** из строк, длина которых **меньше**, *либо* **равна 3 символам**. *Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*
___

### Список файлов проекта

* **BodyScheme.png** - блок-схема основной задачи
* **FindSecondArrayLength.png** - блок-схема метода для нахождения длины итогового массива
* **PrintArray.png** - блок-схема метода вывода массива 
* **Program.cs** - рещение задачи на C#
* **README.md** - документация
___

### Логика решения

1. Задать исходный массив. *(Для удобства в соответствии с ТЗ выбран вариант задать массив сразу на старте выполнения алгоритма)* 
2. Определить длину итогового массива, она будет соответствовать количеству значений исходного массива, которые не превышают 3 символов. Если таких значений в исходном массиве нет, то необходимо задать минимальный размер равный 1. 
3. С помощью цикла передать в итоговый массив все значения размер которых не превышает 3 символа. 
4. Вывести новый массив. Если в исходном массиве не оказалось значений, которые подходят под условие, программа выдаст пустые скобки [].  