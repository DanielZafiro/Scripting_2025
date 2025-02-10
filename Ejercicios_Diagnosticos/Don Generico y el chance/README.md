# Enunciado

_Genérico_ compra un chance en el cual se juega eligiendo un número de 4 dígitos, que se compara con el número resultado del sorteo semanal de los viernes. _Genérico_ apuesta $1000 a un número `num`, esperando que sea igual al número _resultado_ que se conocerá el viernes.

- Escriba una función para determinar si el jugador ganó el sorteo
- El plan de pagos es como sigue:
    - $4500 por cada $1 apostado, si el número es acertado con las cuatro cifras en su orden.
    - $200 por cada $1 apostado, si el número es acertado con las cuatro cifras en desorden
    - $400 por cada $1 apostado, si se aciertan las últimas 3 cifras del número en su orden
    - $50 por cada $1 apostado, si se aciertan las últimas 2 cifras del número en su orden
    - $5 por cada $1 apostado, si se acierta la última cifra del número.
- Escriba una función para determinar, si el jugador obtuvo algún premio, el valor del mismo. En caso contrario, retornar un 0.
