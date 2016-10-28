# Structural Patterns Homework

*   Select 3 structural design patterns
    *   Write a short description (about half page) for each of them
        *   Describe their motivation, intent, applicability, known uses, implementation, participants, consequences, structure, related patterns, etc.
        *   Use [Markdown](https://help.github.com/articles/github-flavored-markdown/) for the description (`.md` files) and upload it on your own GitHub
        *   Prefer Bulgarian language
    *   Provide your own C# examples for their use
    *   Provide a UML diagram or image of the pattern

# Decorator Pattern
   -  Добавя допълнителна функционалност на даден клас. Decorator-а е гъвкава алтернатива на типичното наследяване на класове с цел добавяне на нова функционалност.
   -  Основният плюс от Decorator-а е ,че не засягаме съществуващата конкретна имплементация на дадения клас.
   -  Декоратор класа скрива конкретната имплементация на надградения клас.
   
# Facade Pattern
   -  Чрез този шаблон се представя на ползвателя по опростен начин функционалност зад която стои голямо количество код и например сложни алгоритми
   -  Използва се най-често при библиотеки за готово ползване, които ни предоставят готови функционалности без да ни дават информация как отдолу се случват нещата.
   -  Обединява функционалностите на не добре форматирани методи и класове в едно апи(фасаден клас например),което предоставя ясен и изчистен начин на ползване на библиотеката.
   -  Изчистен от външни зависимости, скрива сложността на изпълнение на дадени операции.