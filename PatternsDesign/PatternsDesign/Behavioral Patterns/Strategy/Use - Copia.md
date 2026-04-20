------------------------------
## Español: Patrón de Diseño Estrategia
El patrón Strategy es un modelo de comportamiento que permite seleccionar un algoritmo o funcionalidad específica en tiempo de ejecución. En lugar de implementar un único algoritmo de forma rígida, el código define una familia de algoritmos y los hace intercambiables.
## Características Principales

* Encapsulamiento: Cada algoritmo vive en su propia clase, separando la lógica de implementación del uso principal.
* Intercambiabilidad: Puedes cambiar el comportamiento de un objeto sin alterar su estructura interna.
* Eliminación de Condicionales: Sustituye estructuras complejas de if-else o switch por polimorfismo.
* Principio de Abierto/Cerrado: Permite añadir nuevas estrategias sin modificar el código que ya funciona.
* Composición: El objeto principal (Contexto) "tiene una" estrategia en lugar de "ser una" implementación fija.

------------------------------
## English: Strategy Design Pattern
The Strategy pattern is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable at runtime.
## Key Characteristics

* Encapsulation: Each algorithm is isolated in its own class, decoupling the implementation logic from the client.
* Interchangeability: It allows an object’s behavior to be swapped dynamically without changing the object itself.
* Refactoring Conditionals: It replaces massive if-else or switch statements with polymorphic calls.
* Open/Closed Principle: You can introduce new strategies without having to change the existing context code.
* Composition over Inheritance: The context maintains a reference to a strategy object instead of inheriting multiple behaviors.

------------------------------
