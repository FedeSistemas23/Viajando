using System;

public class Class1
{
	public Class1()
	{

		// - Requerimientos del login
		/****
		 * 
		 * 
 * 1)El formulario de Login deberá enviar la contraseña encriptada en SHA256.
 * 
 * 
 * 
2) Al momento de guardar la contraseña elegida por el usuario, a la misma se le deberá adosar
el nombre de usuario, encriptando ambos y guardando como contraseña la concatenación de
ambos campos.

3) El sistema, al dar de alta un nuevo usuario por el administrador, deberá generar una primera
contraseña aleatoria al momento de dar de alta dicho usuario, la cual el sistema reconocerá
como primera contraseña, y obligará al usuario a cambiarla antes de ingresar por primera vez al
sistema. En ese mismo acto, le proporcionará una serie de preguntas de seguridad a las cuales
dicho usuario deberá dejar grabada en el sistema las respuestas, para ello el sistema deberá
tener guardadas en su base de datos un total de 15 a 20 preguntas genéricas, de las cuales le
hará responder al usuario 3 de ellas aleatoriamente, almacenando dichas respuestas y a que
pregunta corresponde para ser utilizadas posteriormente en caso de necesidad.

4) El sistema deberá contar con un botón o link en su pantalla de logueo, para recuperar la
contraseña en caso de haber sido olvidada, la cual se generará automática y aleatoriamente por
el sistema, siendo esta nueva contraseña enviada a un correo registrado en el sistema al
momento que el administrador dio de alta al usuario, dicho proceso será efectivo posterior a
que el usuario responda correctamente las preguntas de seguridad del punto 3. Acto seguido a
la generación de la nueva contraseña, el sistema deberá obligar nuevamente al usuario a
cambiarla por una a su elección.

5) En el supuesto caso que el usuario ingresara incorrectamente su contraseña por una cantidad
de veces estipulada y configurada por el administrador, dicho usuario será bloqueado
automáticamente, siendo el administrador el único que pueda desbloquearlo desde el formulario
de “mantenimiento de usuarios”. La cantidad de ingresos fallidos será acumulativa durante el
transcurso del día del suceso, limpiándose el conteo de dichos intentos a las cero horas del día
siguiente de manera automática. Asimismo, el administrador podrá configurar si el usuario, una
vez ejecutado el bloqueo, será desbloqueado automáticamente una vez transcurrido un plazo
determinado.

7) El sistema deberá proporcionar un formulario que solo será accedido por el administrado del
sistema, en el cual se realizará el mantenimiento de usuarios (ABM), este formulario deberá
administrar los datos de las personas, si dicha persona es usuaria del sistema, y de ser así,
configurar su Username y si su Password vence y cada cuanto, obligando a dicho usuario a
cambiarlo una vez transcurrido el lapso de unidades de tiempo estipulados por el administrador.
También en este formulario, el administrador podrá configurar si el sistema le avisara en el
momento del logueo al usuario cuantos días faltan para el vencimiento de su contraseña,
preguntando si desea cambiarla. También deberá configurar a que familia de usuarios
pertenece para que de esa manera se le otorguen los roles (permisos) correspondientes, el
sistema deberá mostrar en este formulario una lista con todos estos permisos, pudiendo el
administrador conceder o quitar roles independientemente de la familia a la que pertenezca el
usuario y si dichos roles caducaran en una fecha determinada.
Por otro parte, este formulario deberá poder dar de alta un usuario “temporal” que contemple
todos los ítems antes mencionados, es decir que dicho usuario caduque en un lapso de tiempo
determinado.


8) El sistema deberá contar con un formulario donde el usuario pueda cambiar su contraseña,
para poder realizar este acto, el usuario deberá responder previamente de manera correcta sus
preguntas de seguridad.

9) El sistema deberá contemplar y proporcionar una pantalla de configuración del mismo, solo
accedida por el administrador, donde se podrá optar por diversas políticas de seguridad tales
como:

a) Verificación de mínimo de caracteres en contraseña.
b) Si se obligara combinación de mayúsculas y minúsculas.
c) Si se obligara a que contenga números y letras.
d) Si se obligara a que contenga al menos un carácter especial.
e) Si se pedirá autenticación en dos FA (autenticación en 2 pasos) utilizando para
ello el correo del usuario.
f) Si no permitirá repetir contraseñas anteriores (para ello el sistema deberá
guardar un registro de todas las contraseñas utilizadas por el usuario
anteriormente)

g) Verificar no contener datos personales, o parte de ellos, registrados al momento
del alta del sistema (como por ejemplo parte del nombre, parte del apellido, la
fecha de nacimiento, etc.)
h) Poder configurar la cantidad de intentos fallidos para bloqueo del usuario.
i) Si el desbloqueo de usuario podrá ser automático y de ser así, configurar el lapso
de tiempo para que esto suceda.
j) Si se realizaran las preguntas de seguridad al usuario.
k) Permitir ingresar nuevas preguntas de seguridad y mostrar la ya almacenadas
en el sistema.
l) En este formulario de configuración de seguridad, el administrador deberá
poder ver las diversas familias de usuario (grupos) pudiendo agregar nuevas,
asimismo, deberá poder agregar y/o quitar funcionalidades del sistema
(permisos) a cada Familia.



		*********Realizado // Falta intefaz de cada solapa
10) Al ingresar al sistema, el mismo deberá abrir una pantalla general con un menú el cual le
dará acceso a los diferentes formularios dependiendo de los niveles de acceso.
		 * 
		 *
		 */

/*
		// vencimiento de cambio de password

		// seleccion desde checkbox cantidad dias
		//forLLogin captura el valor del textbox y se lo pasa a capaNegocio
}
