# Calculate sum of 3 numbers

* This Program request 3 numbers and sum.

#### Declaration:
```c#
int num1 = 0;
int num2 = 0;
int num3 = 0;
string num1_string = null;
string num2_string = null;
string num3_string = null;
```

#### Request numbers:
```c#
// wait the user insert a int no null
do{

    Write("Number 1: ");
    num1_string = ReadLine();
    if (string.IsNullOrEmpty(num1_string))
        WriteLine("Invalid");

} while (string.IsNullOrEmpty(num1_string));
```
#### Convert string to int:
```c#
//convert string to int
num1 = int.Parse(num1_string);
num2 = int.Parse(num2_string);
num3 = int.Parse(num3_string);
```

#### Sum:
```c#
int sum = num1 + num2 + num3;
```

#### code for generate Output:
```c#
// show the sum in console
WriteLine($"{num1} + {num2} + {num3} = {sum}");

// show the total in cosole
WriteLine($"Total: {sum}");
```
#### Output:
```
{num1} + {num2} + {num3} = {sum}
Total: {sum}
```


![icons](https://skills.thijs.gg/icons?i=c,&theme=light)