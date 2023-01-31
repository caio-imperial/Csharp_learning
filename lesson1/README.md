
# Calculate your age

* This Program calculate your age based in your birth year.

#### Variables and Create Object:
```c#
//variables
string name;
int age = 0;

// call the class and instanse object
Person_Console person = new Person_Console();
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

#### Method first_name, return string:
```c#
public string first_name()
```
this method write in console and wait the user insert first name

#### Method calculate_age, return int:
```c#
public int calculate_age()
```
this method write in console and wait the user insert birth year

![icons](https://skills.thijs.gg/icons?i=c,&theme=light)

## Autores

- [@caiosilvestre](https://github.com/caiosilvestre/)