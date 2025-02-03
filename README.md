# Scripting_2025

**Estudiante:** Daniel Esteban Aridla Alzate

**Profesor:** Andres Felipe Perez Campillo

## Enunciado del proyecto del curso

<details>

<summary>Proyecto de Curso (Click Aquí)</summary>

### Proyecto de Curso

La implementación del proyecto del curso se evaluará en cuatro momentos, definidos en el cronograma. A continuación los lineamientos base para su proyecto:

- El proyecto es una implementación corta donde se apliquen los conceptos abordados durante el curso (patrones de diseño de software, pruebas unitarias, estructuras de datos). Ejemplos de implementación que satisfarían este requisito son mecánicas simples, minijuegos, algoritmos para resolver problemas puntuales, etc.
- Puede no implementar absolutamente todo (ej. Descartar estructuras de datos o patrones de diseño) si su implementación no los requiere. No obstante, debe sustentar técnicamente el por qué de su decisión. Como mínimo, debe haber pruebas unitarias y alguno de los dos elementos.
- Patrones requeridos: Cualquiera que crea pertinente, visto o no en clase, más allá del Singleton.
Estructuras de datos requeridos: Cualquiera que crea pertinente, visto o no en clase, más allá de listas o arreglos.
- Usted es libre de elegir las herramientas y caso de estudio que crea pertinentes. Si bien las herramientas de cabecera del curso están definidas, usted puede desarrollar su trabajo en otras que le sean más convenientes.
- El proyecto debe desarrollarse en grupos de no más de 3 personas.
- Entregas del curso:
  - **Propuesta:** Un documento corto donde describa qué hará, qué alcance tendrá, y qué herramientas usará. Describa también los miembros del grupo
  - **Avance 1:** Implementación parcial de la funcionalidad que va a entregar, basado en el progreso del curso. Los criterios de evaluación serán actualizados durante el curso. Siempre se entregan ejecutables para probar la funcionalidad sin abrir el proyecto.
  - **Avance 2:** Implementación parcial (casi completa) de la funcionalidad que va a entregar, basado en el progreso del curso. Los criterios de evaluación serán actualizados durante el curso. Siempre se entregan ejecutables para probar la funcionalidad sin abrir el proyecto.
  - **Sustentación:** Exposición en vivo del caso de estudio, implementación y preguntas alrededor del proyecto. Los criterios de evaluación serán actualizados durante el curso.

**Propuesta - Criterios de evaluación**
- **Alcance (2.5):** El documento define claramente el proyecto que va a desarrollar, y su alcance. Redáctelo de manera que le sirva de guía para dirigir su proyecto (ej. Si usted tiene preguntas sobre el proyecto después de leerlo, necesita refinarlo).
- **Miembros del equipo (1.0):** El documento incluye los miembros del equipo
- **Herramientas (1.5):** Define las herramientas que usará para desarrollar el proyecto.

</details>

> [!NOTE]
> Puede plantear usar proyectos de otros cursos, siempre y cuando esos proyectos puedan satisfacer las necesidades de este curso. En todo caso, usted es responsable de lo que entregue a este curso, si sus compañeros de proyecto no están cursando.

## Propuesta de proyecto "Gimmy"

<details>

<summary>Proyecto Gimmy (Click Aquí)</summary>

### Propuesta de Proyecto

#### 1. Descripción del proyecto
El proyecto consiste en desarrollar una interfaz con un minijuego(como base para otros minijuegos) en **Unity** que integre la información proveniente de un dispositivo externo llamado **Gimmy** (un prototipo físico con acelerómetro e imán), el cual se adhiere a superficies metálicas o pesas de máquinas de ejercicio. El dispositivo enviará datos a una aplicación (ya sea para móvil o web) y, a su vez, esos datos serán usados en el minijuego de Unity para brindar una experiencia gamificada al usuario durante su rutina de ejercicio, aplicando así elementos prácticos para actividades cotidianas cómo se menciona en el libro hábitos atómicos.

- **Funcionalidad principal:** A través de la **información de movimiento** (e.g., aceleración, posición, conteo de repeticiones), el minijuego representará de manera visual y lúdica las repeticiones del usuario. Por ejemplo, podría mostrar un círculo que se desplaza por un camino; cada repetición controlará el avance del círculo, y el objetivo es no salirse del camino. Dependiendo del objetivo del usuario podría ser adaptativo de manera que si por ejemplo se quiere aumentar de peso el minijuego mueva el círculo más lento cuando se está soltando el peso.
- **Gamificación:** Se pretende que el usuario vea en tiempo real (o casi en tiempo real) los resultados de sus ejercicios en el juego, motivándolo a cumplir de forma adecuada sus series y repeticiones mientras observa su progresión.

#### 2. Alcance

1. Integración de datos:
    - Procesar la información proveniente de Gimmy (que simulará o enviará datos de movimiento/posición).
    - Visualizar en Unity un avatar u objeto que reaccione de acuerdo con dichos datos.

2. Arquitectura de software y patrones de diseño:
    - Se implementará al menos un **patrón de diseño** que resulte pertinente para la gestión de los datos del dispositivo y la comunicación con el minijuego. Algunos candidatos podrían ser:
      - **Observer** para notificar a la interfaz del juego cada vez que se recibe nueva información de movimiento.
      - **Strategy** si se contemplan diferentes modos de procesar los datos (por ejemplo, distintas rutinas de ejercicio que requiera lógicas diferentes).
    - **Evitar el uso exclusivo de Singleton** sin justificación. La idea es aplicar otros patrones y explicar el porqué de su elección.

3. Estructuras de datos:
    - Se considera el uso de **colas (queue)** o **pilas (stack)** para manejar los eventos de datos entrantes (lecturas del dispositivo).
    - Se podrían usar estructuras más avanzadas si el minijuego crece en complejidad (por ejemplo, árboles para almacenar progresos de diferentes ejercicios o repeticiones).
    - Se justificará técnicamente la elección de la estructura de datos adecuada.

4. Pruebas unitarias:
    - Se crearán **pruebas unitarias** para validar la lógica que procesa la información del dispositivo.
    - Por ejemplo, verificar que, al recibir datos de aceleración, el juego incremente correctamente el contador de repeticiones o que el objeto en pantalla se mueva según lo esperado.

5. Finalización y entregables:
    - Al final, se presentará un **ejecutable** (build de Unity) con la funcionalidad principal implementada para que se pueda probar sin necesidad de abrir el proyecto en el editor.
    - Documentación explicando el uso de los patrones de diseño y las estructuras de datos elegidas, junto con las **pruebas unitarias** implementadas.
  
#### 3. Herramientas

- **Unity [versión Unity 6 (6000.0.34f1)]:** Motor de desarrollo de videojuegos para crear la interfaz y el minijuego.
- **Lenguaje C#:** Para la programación de la lógica dentro de Unity.
- **Visual Studio o VS Code:** Entorno de desarrollo para escribir el código C# y ejecutar pruebas unitarias.
- **GitHub:** Para control de versiones y manejo colaborativo, aunque el equipo sea de un solo integrante podría agregar colaboradores(profesor).
- **Framework de pruebas unitarias de Unity** (Unity Test Framework) o NUnit (si se integra externamente) para validar la lógica.

#### 4. Miembro(s) del equipo

Con deseo de trabajar con mas personas en el equipo para aprender a manejar el control de versiones sobre el mismo proyecto.
- **Nombre:** Daniel Esteban Ardila Alzate
- **Rol:** Desarrollador único (todas las fases del proyecto).

**Observaciones finales**
- Este proyecto lo traje de la materia de **Gestión y Planificación de Proyectos de Entretenimiento Digital por Ariel Humberto Acevedo Acosta** y se relaciona directamente con la materia de **Sistemas Físicos Interactivos 1 y 2 de Juan Fernando Franco Higuita.**
- Se alinea con la propuesta de negocio “Gimmy” desarrollada en la materia de Gestión y Planificación de Proyectos, pero se concentrará en la parte de **scripting** y **desarrollo de un minijuego como mínimo o como base para más propuestas**.
- Se profundizará en la arquitectura de software **aplicando patrones de diseño** y estructuras de datos seleccionadas para la recepción, procesamiento y visualización de la información proveniente del dispositivo.
- Se justificarán las decisiones técnicas en relación con la pertinencia de cada estructura o patrón, y **se incluirán pruebas unitarias** en el desarrollo.



</details>
