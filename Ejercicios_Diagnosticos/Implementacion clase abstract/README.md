# Enunciado

- Implemente lo siguiente:
    - Una clase abstracta _AbstractSample_ con los siguientes elementos:
        - Un atributo privado message, 
        - Un método abstracto _PrintMessage_
        - Un método virtual _InvertMessage_.
            - Ambos métodos reciben un string como parámetro.
            - InvertMessage invierte message
    - Dos subclases de _AbstractSample_ (nombres a su discresión):
        - Una implementa _PrintMessage_ imprimiendo message
        - Otra implementa _PrintMessage_ imprimiendo message con mayúsculas y minúsculas invertidas.
        - Una de las clases sobreescribe _InvertMessage_ para que, además de lo que hace, cambie mayúsculas por minúsculas.

    - Una clase _MessageManager_ que instancie dos objetos _AbstractSample_ e invoque sus métodos _PrintMessage_.
