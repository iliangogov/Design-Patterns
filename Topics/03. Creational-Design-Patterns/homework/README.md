# Creational Patterns Homework

*   Select 3 creational design patterns
    *   Write a short description (about half page) for each of them
        *   Describe their motivation, intent, applicability, known uses, implementation, participants, consequences, structure, related patterns, etc.
        *   Use [Markdown](https://help.github.com/articles/github-flavored-markdown/) for the description (`.md` files) and upload it on your own GitHub
        *   Prefer Bulgarian language
    *   Provide your own C# examples for their use
    *   Provide a UML diagram or image of the pattern
    
    # Singleton
    - Singleton класа ни гарантира една единствена инстанция на обекта, като осигурява глобален достъп до тази инстанция.
        - Примери :  файлова система, конзола, logger...
        - Може да се използва когато: 
        1) има нужда от една единствена инстанция на даден обект с цел да се избегнат евентуални грешки породени от съсдаването на друга инстанция на този обект
        2) създаването на обекта е скъпо(бавно) и за предпочитане е да се преизползва единствената инстанция
        3) когато има нужда от глобален достъп до този обект
        
        - Недостатъци : hard coupling, чупи Single Responsibility принципа и Open/Closed принципа, затруднява тестването
        
    # Simple Factory
      - Клас или метод който създава други обекти според дадена енумерация или стринг което определя какъв обекта трябва да създаде този клас.
         - Полезни страни: 
         1) симпъл фактори скрива логиката на създаване на обектите
         2) подобрява Single Responsibility принципа, вместо даден метод или клас да знае как се създава обект, той просто си го извиква от факторито
         3) ако е нужна промяна в логиката на създаване на обекти е ясно къде да се направи и обикновено е само на едно място
      
      

    
