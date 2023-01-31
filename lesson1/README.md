
# Calculate your age

* This Program calculate your age based in your birth year.

#### Variables:
```c#
string name;
int year;
string year_string;
```

#### Request name of user:
```c#
// wait  insert user a name different the null
do {
                
    Write("Frist Name: ");
                
    //get input
    name = ReadLine();
                
    // erro mensage
    if(string.IsNullOrEmpty(name))
        WriteLine("Invalid");
            
}while(string.IsNullOrEmpty(name));
```

#### Request birth year of user:
```c#
do{
                
    //write  in console 
    Write("Your birth year:");
                
    //get input
    year_string = ReadLine();

    // erro mensage
    if(string.IsNullOrEmpty(year_string))
        WriteLine("Invalid");
                
}while(string.IsNullOrEmpty(year_string));
```

#### Convert string to int:
```c#
year = int.Parse(year_string);
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

