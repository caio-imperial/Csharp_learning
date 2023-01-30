
# Calculate your age

* This Program calculate your age based in your birth year.

#### Request name of user:
```c#
Write("Frist Name: ");
string name = ReadLine();
```

#### Request birth year of user:
```c#
Write("Your birth year:");
// wait the user year and convert string to int.
int year = int.Parse(ReadLine());
```

#### Calculate age of user:
```c#
int age = 2022 - year;
```

#### code for generate Output:
```c#
WriteLine($"\nHi {name}!");
//write age in console
WriteLine($"Your age is: {age}");
//check if age is over 21
if( age >= 21 )
{
    WriteLine("To be over 21 \n");
}
else 
{
    WriteLine("To be under 21 \n");
}
```
#### Output:
```

Hi {name}!"
Your age is: {age}
To be over 21 or To be under 21

```


![icons](https://skills.thijs.gg/icons?i=c,&theme=light)





## Autores

- [@caiosilvestre](https://github.com/caiosilvestre/)

