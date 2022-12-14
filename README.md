# Задание на проверку знаний по Git, GitHub, Markdown и C#

## Порядок действий:

1. Чтобы решить задачу, необходимо спроектировать блок-схему для наглядности используемого алгоритма.

2. Создав репозиторий на GitHub, необходимо загрузить туда README файл, оформленный в стилистике markdown, сделав нужный commit. Файл будет описывать ход действий при выполнении контрольной работы.

3. Загрузить диаграмму картинкой, отдельным коммитом.

4. Создать папку для решения задачи вместе с нужными файлами через dotnet new console.

5. Написать код и решить задачу, переодически делая commits по ходу выполнения работы.


## Описание решения задачи:

* Инициализируем заданный массив строк, вводим глобальные переменные `count`/`result`.
* С помощью цикла for проходимся по длине массива `originalArray`.
* С помощью проверки `if`, выделяем кол-во элементов с длиной меньше 4 и записываем их в `count`.
* Инициализируем новый строчный массив `sortedArray` с кол-вом элементов `count`.
* С помощью аналогичного цикла for и проверки `if` проходимся по элементам `originalArray` и записываем строки с длиной менее 4 символов в массив `sortedArray[]`, увеличивая индекс.
* Выводим конечный массив со строками, длина которых меньше либо равна 3 символам.
