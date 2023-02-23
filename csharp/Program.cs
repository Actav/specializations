/*
Создать пустой список строк result.
Перебрать все строки str в исходном массиве строк arr.
Если длина строки str меньше или равна 3 символам, добавить ее в список result.
Вернуть список result.
*/

string[] inputArray = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
string[] outputArray = GetShortStrings(inputArray);

printResult(inputArray, outputArray);

string[] GetShortStrings(string[] inputArray) {
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++) {
        if (inputArray[i].Length <= 3) {
            count++;
        }
    }
    string[] outputArray = new string[count];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++) {
        if (inputArray[i].Length <= 3) {
            outputArray[index] = inputArray[i];
            index++;
        }
    }
    return outputArray;
}

void printResult(string[] inputArray, string[] outputArray) {
    System.Console.Write($"[\"{String.Join("\", \"", inputArray)}\"] -> [\"{String.Join("\", \"", outputArray)}\"]\n");
}
