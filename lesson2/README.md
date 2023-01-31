# Calculate sum of 3 numbers

* This Program request 3 numbers and sum.

#### Declaration:
```c#
int num1 = 0;
int num2 = 0;
int num3 = 0;
```

#### Request numbers:
```c#
// wait the user insert a int
do{
    try{
        Write("Number 1: ");
        num1 = int.Parse(ReadLine());
        erro = false;
    }
    catch{
            WriteLine("Invalid number");
    }
} while (erro == true);
```

#### Reset erro:
```c#
erro = true;
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

## Author

- [@caiosilvestre](https://github.com/caiosilvestre/)