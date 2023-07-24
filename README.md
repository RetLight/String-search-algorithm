# Programa de Busqueda de cadenas con tres diferentes algoritmos: Knuth Morris Pratt, Brute Force y Boyer Moore

Este programa en C# consta de tres pantallas y 4 funciones pincipales. En primer lugar, "login", esta función consta de la validación de las credenciales de los usuarios que traten de ingresar al programa. Para este se le pide su codigo y su contraseña. En segundo lugar, "registrar", esta función tiene que ver con la carga de archivos al programa. El programa puede registrar archivos de tipo pdf, word y txt. En tercer lugar, "buscar", esta función consta de la busqueda de alguna palabra u oración en alguno de los archivos registrados por el usuario utilizando alguno de los siguiente algoritmos de busqueda de cadenas: Knuth Morris Pratt, Brute Force o Boyer Moore. Finalmente, la funcion "historial" muestre todos las busquedas realizadas por el usuario, así como el tiempo que se tomó realizaralas y el resultado obtenido.

## 1. Pantalla de Validación de Credenciales

En esta ventana, el usuario debe ingresar sus credenciales para poder acceder a las funcionalidades del programa. Si las credenciales son válidas, se le permitirá avanzar a la segunda pantalla; de lo contrario, el acceso será denegado y se permanecerá en la presente pantalla.

Para el manejo de las credenciales se optó por almacenar la información en archivos de texto. 

## 2. Pantalla de Gestión de Archivos y Búsqueda de Cadena

Una vez que el usuario ha ingresado con éxito, accederá a esta pantalla, donde encontrará las siguientes funciones:

### 2.1 Cargar y Guardar Archivos

En esta sección, el usuario podrá cargar archivos con los siguientes formatos: PDF, Word (docx) y texto  (txt). Una vez dentro del proyectos, aquellos archivos que no sean de tipo .txt se convertirán a este formato y se alamcenrán en el programa.

### 2.2 Búsqueda de Cadenas

En esta sección, el usuario podrá buscar una palabra u oración específica dentro del archivo de texto previamente cargado y guardado. Para realizar la búsqueda, el programa empleará tres algoritmos diferentes:

1. **Brute Force**:
  El algoritmo de Brute Force, también conocido como fuerza bruta, es uno de los enfoques más sencillos para buscar una cadena en un texto. Consiste en comparar       cada carácter del texto con el primer carácter de la cadena que se busca. Si hay una coincidencia, se compara cada carácter secuencialmente hasta que se encuentra   la cadena completa o se agota la búsqueda.
  
  Pasos del Algoritmo:
  1. Iniciar un bucle desde el inicio hasta el final del texto.
  2. En cada iteración, comparar el carácter actual del texto con el primer carácter de la cadena buscada.
  3. Si hay una coincidencia, comenzar otro bucle para comparar los caracteres restantes de la cadena con los caracteres correspondientes del texto.
  4. Si se encuentra una coincidencia completa, aumentar el contador de ocurrencias y continuar con la búsqueda.
  5. Repetir el proceso hasta que se haya revisado todo el texto.
     
  El algoritmo de Brute Force es sencillo de implementar, pero puede ser ineficiente para textos muy grandes debido a su complejidad lineal O(n*m), donde "n" es       la longitud del texto y "m" es la longitud de la cadena buscada.

2. **Knuth Morris Pratt**:
  El algoritmo de Knuth Morris Pratt (KMP) es un método más sofisticado para buscar una cadena en un texto. Se basa en el concepto de un preprocesamiento de la        cadena a buscar para evitar comparaciones redundantes durante la búsqueda.

  Pasos del Algoritmo:
  1. Construir una tabla de prefijos (lps - Longest Proper Prefix Suffix) para la cadena buscada.
  2. Iniciar dos índices, uno para el texto (i) y otro para la cadena buscada (j).
  3. Recorrer el texto mientras i < n (longitud del texto) y j < m (longitud de la cadena buscada).
  4. Si el carácter en el índice i del texto coincide con el carácter en el índice j de la cadena buscada, incrementar ambos índices (i y j).
  5. Si j alcanza la longitud de la cadena buscada, se ha encontrado una coincidencia completa. Aumentar el contador de ocurrencias y actualizar j utilizando la          tabla    de prefijos (lps).
  6. Si hay una discrepancia entre los caracteres, actualice j utilizando la tabla de prefijos y vuelva a intentar la comparación con el nuevo valor de j.
  7. Repetir el proceso hasta que se haya revisado todo el texto.
  
  El algoritmo KMP tiene una complejidad lineal de O(n + m) debido al preprocesamiento de la tabla de prefijos, lo que lo hace más eficiente para búsquedas en         textos grandes.

4. **Boyer Moore**:
  El algoritmo de Boyer Moore es otro método eficiente para la búsqueda de cadenas. Se centra en desplazar la ventana de comparación hacia la derecha en lugar de      uno o varios caracteres, lo que lo hace muy rápido en la mayoría de los casos.

  Pasos del Algoritmo:
  1. Construir dos tablas de desplazamiento: una tabla de salto de caracteres y una tabla de salto de sufijos.
  2. Iniciar un índice i en el comienzo del texto y un índice j en el comienzo de la cadena buscada.
  3. Realizar una búsqueda desde el final de la cadena buscada hacia el inicio del texto.
  4. En cada iteración, comparar el carácter en el índice j con el carácter en el índice i del texto.
  5. Si hay una coincidencia, disminuir los índices i y j para seguir comparando hacia atrás.
  6. Si se encuentra una discrepancia, utilizar las tablas de desplazamiento para calcular el nuevo índice de i y j y realizar el desplazamiento hacia la derecha.
  7. Repetir el proceso hasta que se haya revisado todo el texto.
     
  El algoritmo de Boyer Moore puede ser muy eficiente en la mayoría de los casos, especialmente cuando el texto contiene repeticiones de patrones, ya que permite      desplazar la ventana más rápidamente. Su complejidad es lineal, O(n + m), lo que lo hace adecuado para textos grandes.

Una vez finalizadas las búsquedas, el programa mostrará en pantalla la cantidad de instancias de la palabra u oración del texto seleccionado.

### 2.3 Ver Historial de Búsquedas

En esta sección, el usuario podrá ver el historial de todas las búsquedas realizadas durante la sesión actual. El historial incluirá información sobre las palabras u oraciones buscadas, el texto y algoritmos seleccionados, así como la cantidad de instancias de la palabra y el tiempo de la busqueda.

Para una mejor administración de estos datos se utiliza un archivo de texto que incluye toda esta información.

Estas fueron las funciones principales del programa presentado.

## Requisitos y Consideraciones

- El programa debe estar desarrollado en C#.
- Se debe implementar una interfaz gráfica (GUI) que permita al usuario interactuar con las diferentes funcionalidades.
- Se recomienda utilizar las bibliotecas o librerías apropiadas para la manipulación de archivos PDF, Word y texto plano.

## Nota

Este es solo un README.md que describe las funcionalidades y características del programa propuesto. No proporciona el código fuente detallado del programa.
