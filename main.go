package main

import "fmt"

func main() {
	// Исходный срез строк
	strArr := []string{"one", "two", "three", "four", "five", "six"}

	// Объявляем пустой срез строк для хранения результатов
	resultArr := []string{}

	// Проходимся по каждой строке в исходном массиве
	for _, str := range strArr {
		// Если длина строки меньше или равна 3, добавляем ее в результирующий срез
		if len(str) <= 3 {
			resultArr = append(resultArr, str)
		}
	}

	// Выводим результирующий срез в консоль
	fmt.Println(resultArr)
}
