# Ejercicios de Físicas 3D – Unity

## Descripción

Proyecto realizado en Unity 6.6 para practicar el funcionamiento de las físicas en entornos 3D mediante componentes Rigidbody, Collider, detección de colisiones y movimiento de objetos.

## Ejercicio 1. Configuraciones físicas

Se han realizado nueve pruebas modificando las propiedades físicas de un plano, un cubo y una esfera.

Se han probado diferentes configuraciones:

1. Plano sin Rigidbody, cubo con Rigidbody y esfera sin Rigidbody.
2. Plano sin Rigidbody, cubo y esfera con Rigidbody.
3. Esfera con Rigidbody y opción Is Kinematic activada.
4. Los tres objetos con Rigidbody dinámico.
5. Objetos con diferentes masas.
6. Esfera con una masa 100 veces superior a la del cubo.
7. Plano cinemático y esfera con material físico de fricción.
8. Esfera cinemática con Is Trigger activado.
9. Esfera dinámica con Is Trigger activado.

**Resultados:**

- Los objetos sin Rigidbody no responden a la gravedad.
- Los objetos dinámicos caen y reaccionan ante las colisiones.
- Los objetos cinemáticos no se comportan como objetos dinámicos.
- La masa influye en el comportamiento de las colisiones.
- La fricción modifica el comportamiento del contacto entre superficies.
- Los colliders configurados como Trigger detectan contactos sin producir colisiones físicas normales.

### Demostraciones

![Configuraciones físicas A](Assets/Documentation/Ejercicio1_ConfiguracionesFisicas_A.gif)

![Configuraciones físicas B](Assets/Documentation/Ejercicio1_ConfiguracionesFisicas_B.gif)

## Ejercicio 2. Controlador de movimiento

Se ha creado un cilindro controlado mediante las flechas del teclado utilizando un componente Rigidbody.

**Resultados:**

- El cilindro se desplaza en cuatro direcciones.
- Se utiliza AddForce para aplicar fuerzas mediante físicas.
- Se limita la velocidad de movimiento.
- Se bloquean las rotaciones X y Z para evitar que el cilindro vuelque.

### Demostración

![Controlador](Assets/Documentation/Ejercicio2_Controlador.gif)

## Ejercicio 3. Detección de colisiones y cambio de color

Se han creado objetos con Rigidbody y Collider para comprobar la detección de colisiones.

Se ha utilizado el método OnCollisionEnter para detectar cuándo dos objetos entran en contacto.

**Resultados:**

- Se muestra en la consola el nombre del objeto con el que se produce la colisión.
- Los objetos cambian de color aleatoriamente al colisionar.

### Demostraciones

![Detección de colisiones](Assets/Documentation/Ejercicio3_Colisiones.gif)

![Colisiones y colores](Assets/Documentation/Ejercicio3_Colisiones_Color.gif)

![Cambio de color](Assets/Documentation/Ejercicio3_CambioColor.gif)

## Ejercicio 4. Movimiento hacia un objetivo y obstáculo

Se ha creado una escena con una esfera, un cilindro y un cubo.

La esfera se desplaza automáticamente hacia el cilindro utilizando su posición como objetivo.

El cubo actúa como obstáculo y, cuando la esfera colisiona con él:

- Cambia su color a rojo.
- Comienza a desplazarse hacia delante.

**Resultado:**

Se consigue detectar la colisión entre la esfera y el obstáculo y modificar el comportamiento del cubo mediante físicas.

### Demostración

![Movimiento hacia el objetivo y obstáculo](Assets/Documentation/Ejercicio4_Obstaculo.gif)

## Conclusión

Con esta práctica se han trabajado los conceptos fundamentales de las físicas 3D en Unity, aprendiendo a utilizar Rigidbody, Collider, Is Kinematic, Is Trigger, masas, fricción, fuerzas y detección de colisiones.

También se ha practicado el movimiento de objetos mediante código C# y la interacción entre diferentes elementos de una escena.

## Herramientas utilizadas

- Unity 6.6
- C#
- Visual Studio
- Git y GitHub