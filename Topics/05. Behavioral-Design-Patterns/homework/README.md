# Behavioral Patterns Homework

*   Select 4 behavioral design patterns
    *   Write a short description (about half page) for each of them
        *   Describe their motivation, intent, applicability, known uses, implementation, participants, consequences, structure, related patterns, etc.
        *   Use [Markdown](https://help.github.com/articles/github-flavored-markdown/) for the description (`.md` files) and upload it on your own GitHub
        *   Prefer Bulgarian language
    *   Provide your own C# examples for their use
    *   Provide a UML diagram or image of the pattern

# Chain of Responsibility Pattern 

 - Използвайки този шаблон можем да поддаваме дадена заявка от един обект(клас) към следващия докато заявката не бъде изпълнена.
 - Това ни осигурява да определим точно реда на обектите през които искаме да мине дадената заявка.
 - Опростява връзките между обектите, тъй като всеки обект държи в себе си една единствена референция а именно към следващия обект на който да подаде заявката.
 - По този начин се създава "дърво" на отговорностите т.е. обекта обработва заявката ако може да го направи и/или я праща на следващия по веригата.
 
# Template Method Pattern
 - Използвайки този шаблон оставяме дадена функционалност от базовия клас да бъде доимплементирана от неговите наследници.
 - Обикновено се изразява в овърайдване на абстрактни или виртуални методи.
 - Надграждането може да стане постъпково от наследниците. 
 - Улеснява се преизползването на код без да има повтаряемост.
 
# Strategy Pattern
 - Използвайки този шаблон енкапсулираме отделни алгоритми и ги правим взаимо заменяеми когато те изпълняват една и съща задача.
 - Потрбителя може лесно да замени желания алгоритъм, тъй като той се подава като интерфейс на класа който го ползва.
 - Плюсовете са че кода и различните стратегии са лесно тестваеми и добавянето на нови алгоритми не променя съществуващите имплементации.