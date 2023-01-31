
# Calculate your age

* This Program calculate your age based in your birth year.

#### Variables:
```c#
//variables
string name;
int age = 0;

// call the class and instanse object
Person_Console person = new Person_Console();
```

#### Request name and birth year:
```c#
// write in console
WriteLine("Fill in the request below !!!\n");
// call method to request name
name = person.first_name();

// call method to request birth year
age = person.calculate_age();
```

#### Declarate variables in class Person_Console:
```c#
private int year_now = DateTime.Now.Year;
private string name;
private int year;
private int age;
```

#### Method calculate_age, return int:
```c#
bool error = true;
do{
    try{
        //write  in console
        Write("Your birth year:");
        //get input
        year = int.Parse(ReadLine());
        error = false;
    }catch{
        // erro mensage
        WriteLine("Invalid");
    }
} while (error == true);

age =  year_now - year;

return age;
```

#### Method first_name, return string:
```c#
// wait  insert user a name different the null
do{

    Write("First Name: ");

    //get input
    name = ReadLine();

    // erro mensage
    if (string.IsNullOrEmpty(name))
        WriteLine("Invalid");

} while (string.IsNullOrEmpty(name));

return name;
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

