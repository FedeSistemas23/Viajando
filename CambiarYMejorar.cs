using System;

public class Class1
{
	public Class1()
	{

        /*
         * --5/07/2024
         * 
		 * Al apretar link olvide contraseña se abre formulario para mandar contraseña aleatoria al mail. Este formulario
		 * tiene el link "volver" en la párte de abajo. al apretarlo vulve al login, pero deja abierto el formulario de 
		 * preguntas aleatorias

		PreguntasSeguridad.CS
		Linea 59


        private void btnVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.ShowDialog();
            
        }
		

		--MEJORAR--
		* Deberia cerrarse el formulario al apretar volver
		* 
		* 2 - LOGIN
		* 
		* BOTON ENVIAR : SE HABILITA CUANDO EL TEXTBOX CONTRASEÑA TEXT CHANGE. 
		* NO IMFORMA ERROR CUANDO NO SE INGRESA CONTRASEÑA
		* SE HABILITA EL BOTON IGUAL.
		-------------------------------------------------------------------------------


		 * vas a hacer un metodo que evalue los tres textbox. verdadero o falso si textbox.text!="" 1 && 2 && 3 simultaneamente
		 * if true btn enabled true, else false. crear en [CAPA SERVICIO]
		 * [primer ingreso] en los tetxbox. textchange
		 * 
		 * [IZ.PPAL]Y[FORM1] cortar los metodos de hasheo2 y generar contraseña aleatoria y los pegues en la capa servicios y llames ese metodo en las otras 2 capas.
		 * [CAMBIAR CONTRASEÑA] habilitar el mismo metodo
		 * [PREGUNTAS SEGURIDAD] crear metodo traer respuestas, usando la variable idUsuario buscas las respuestas y las metes en un array y haces un for que de 0 a 3
		 * y comparar el tetxo con la posiion [i] del array. si el metodo devuelve true llama al metodo de crear contraseña aleatoria y enviar a mail.
		 * 
		 * [PRIMER INGRESO] lograr que abra el form de cambio de contraseña
		 * lograr cambiar contraseña exitosamente (asegurate de escribirla antes)
		 * probar la nueva contraseña
		 * si funciona retirar las // de [PRIMER INGRESO] en guardar respuestas.
		 * */
    }
}
