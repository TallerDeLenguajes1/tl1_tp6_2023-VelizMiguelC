# tl1_tp6_2023-VelizMiguelC
# ¿String es una tipo por valor o un tipo por referencia?
## String es una variable tipo por valor referencia, aunque se comporte como una por valor, ya que se reserva un espacio en el heap para almacenar el valor de la cadena. Cuando se asigna una cadena a otra variable o se pasa como argumento a un método, en realidad se está pasando una referencia al objeto de cadena en el heap, no una copia del valor en sí.
# ¿Qué secuencias de escape tiene el tipo string?
## Las secuencias de escape mas comunes son:
\": Representa el carácter de comilla doble (").
\': Representa el carácter de comilla simple (').
\\: Representa el carácter de barra invertida (\).
\n: Representa un salto de línea.
\r: Representa un retorno de carro.
\t: Representa un tabulador horizontal.
\b: Representa un retroceso (borrado de un espacio).
\f: Representa un avance de formulario.
\v: Representa un tabulador vertical.
# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
## Cuando se utiliza el carácter @ antes de una cadena de texto en C#, hace que los caracteres especiales tales como \ y otros sean tratados como caracteres normales
## El carácter $ se utiliza para habilitar las cadenas interpoladas, también conocidas como cadenas interpoladas de formato. Una cadena interpolada permite incrustar expresiones o variables dentro de una cadena utilizando la sintaxis ${expression}.
# Busque en diferentes bibliografías que son y cómo funcionan las expresiones regulares.
# ¿Funcionan únicamente en C#?
## Las expresiones regulares no funcionan únicamente en C#. Son compatibles con muchos lenguajes de programación, como Python, Java, JavaScript, Ruby, Perl y otros.
# ¿En qué casos le parecen útiles? Enuncie al menos 3.
## Las expresiones regulares son útiles en una variedad de casos, entre ellos:

## a) Validación de entradas de usuario: Pueden usarse para verificar si un texto ingresado por el usuario cumple con un formato específico, como una dirección de correo electrónico válida, un número de teléfono, una URL, etc.

## b) Búsqueda y extracción de información: Las expresiones regulares permiten buscar y extraer información específica dentro de un texto. Por ejemplo, puedes usar una expresión regular para encontrar todas las direcciones de correo electrónico en un documento o extraer los números de teléfono de una página web.

## c) Transformación de texto: Las expresiones regulares pueden utilizarse para realizar manipulaciones complejas en el texto, como reemplazar ciertos patrones con otro texto, eliminar espacios en blanco, formatear fechas, etc.
# ¿Cómo se hace uso de estas en C#?
## En C#, puedes hacer uso de expresiones regulares utilizando el namespace System.Text.RegularExpressions.

