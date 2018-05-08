# MaquinaTuring  
Descripción del proyecto
---  
Simulador de varias máquinas de Turing. La intención del proyecto es aprender a detalle el diseño y el funcionamiento de dichas máquinas, como base de los procesadores modernos.  
Maquinas de turing:  
1. Reconocedor de cadenas palíndromas: Reconoce una cadena de a, b o c’s y verifica que la cadena sea un palíndromo.  
2. Copia de patrones: Reconoce un patrón de a, b o c’s y lo copia de manera idéntica.  
3. Multiplicación en código unario: Reconoce una cadena y realiza la multiplicación respectiva.  
4. Suma en código unario: Reconoce una cadena y realiza la suma respectiva.  
5. Resta en código unario: Reconoce una cadena y realiza la resta respectiva.  

Funcionamiento de la aplicación
---
#### 1. Ingreso de la entrada.   
Primero debe seleccionar una de las cinco maquinas de turing previamente mencionadas. Luego se procede a ingresar una cadena en el textbox correspondiente y se
presiona el botón *Ingresar*. Si la cadena que ingresó contiene símbolos que no pertenecen al alfabeto de entrada de la máquina de turing la aplicación mostrará
una ventana emergente indicando el error. Sin embargo, si la cadena de entrada es ingresada correctamente se procederá a mostrar la cinta de la máquina, así como
también su respectiva tabla de transiciones y se habilitaran los botones para evaluar la cadena y para mostrar el diagrama de la maquina de turing seleccionada.   

#### 2. Evaluar la cadena de entrada.    
La cadena puede ser evaluada manualmente por medio del botón *Avanzar*, esto se recomienda si se desea entender el funcionamiento de la máquina pues permitirá mostrar
paso a paso el comportamiento de la misma así como también sus funciones de transición y su estado actual. Sin embargo, si el estudio de la máquina no es el objetivo se puede optar por la opción *Avance Rápido*, la cual muestra la evaluación de la cadena a una velocidad moderada.   

#### 3. Resultado de la evaluación.   
Al terminar de evaluar la cadena de entrada el programa mostrará en la parte inferior un mensaje indicando si la cadena fue aceptada o rechazada por la máquina de
turing. Si desea evaluar otra cadena solamente debe ingresarla en la caja de texto y presionar nuevamente el botón *Ingresar*, esto iniciará nuevamente el procedimiento. Las máquinas desarrolladas fueron sometidas a varias pruebas que confirman su correcto funcionamiento y la robustez de la aplicación.