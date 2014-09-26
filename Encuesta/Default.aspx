<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Encuesta.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
            <div class="page-header">
	            <h1>ASP<span><small> Cuestionario</small></span></h1>
	        </div>   
                <asp:Label ID="Label21" runat="server" Text="Escribe tu nombre:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="280px"></asp:TextBox><br /><br />
                <asp:Label ID="Label1" runat="server" Text="1- ¿Que es una aplicación Web?"></asp:Label >
                <asp:Image ID="Image1" runat="server" CssClass="calificacion" /><br /><br />
                <asp:Panel ID="Panel1" runat="server">
                    <asp:RadioButton ID="p1a" runat="server" GroupName="p1" Text=" a.- Conjunto o agrupación de IAM" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p1b" runat="server" GroupName="p1" Text=" b.- a y e" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p1c" runat="server" GroupName="p1" Text=" c.- Elementos de PHP" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p1d" runat="server" GroupName="p1" Text=" d.- Clases hechas en HTML" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p1e" runat="server" GroupName="p1" Text=" e.- Conjunto de paginas HTML" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label2" runat="server" Text="2- ¿Por medio de que protocolo se transmiten las paginas HTML?"></asp:Label>
                <asp:Image ID="Image2" runat="server" CssClass="calificacion" /><br /><br />
                <asp:Panel ID="Panel2" runat="server">
                    <asp:CheckBox ID="p2a" runat="server" Text=" a.- FTP" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p2b" runat="server" Text=" b.- SMTP" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p2c" runat="server" Text=" c.- HTTP" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p2d" runat="server" Text=" d.- DNS" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p2e" runat="server" Text=" e.- SSH" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label3" runat="server" Text="3- ¿Qué es ASP.NET?"></asp:Label>
                <asp:Image ID="Image3" runat="server" CssClass="calificacion"/>
                <br /><br />
                <asp:Panel ID="Panel3" runat="server">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>a.- Es un Framework</asp:ListItem>
                        <asp:ListItem>b.- Es un constructor para programar aplicaciones Web </asp:ListItem>
                        <asp:ListItem>c.- Es una variable para programar aplicaciones Web</asp:ListItem>
                        <asp:ListItem>d.- Es un macro para programar aplicaciones Web</asp:ListItem>
                        <asp:ListItem>e.- Es un IDE</asp:ListItem>
                    </asp:DropDownList><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label4" runat="server" Text="4- ¿Cuáles son los componentes principales de un ASP.NET?"></asp:Label>
                <asp:Image ID="Image4" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel4" runat="server">
                    <asp:CheckBox ID="p4a" runat="server" Text="a.- Las lineas de código" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p4b" runat="server" Text="b.- Los Web Forms" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p4c" runat="server" Text="c.- Las extenciones aspx" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p4d" runat="server" Text="d.- INCLUDE" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p4e" runat="server" Text="e.- Clases" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label5" runat="server" Text="5- Qué es un servidor Web"></asp:Label>
                <asp:Image ID="Image5" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel5" runat="server">
                    <asp:RadioButton ID="p5a" runat="server" GroupName="p2" Text="a.- Sistemas inteligente que facilita la cración de paginas imagenes, etc." AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p5b" runat="server" GroupName="p2" Text="b.- Sistemas informatico que no debe estar a la red porque se produciran errores." AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p5c" runat="server" GroupName="p2" Text="c.- Sistemas informático conectado a la red donde se almacenan páginas imagenes, etc." AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p5d" runat="server" GroupName="p2" Text="d.- Almacenador de paginas web" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p5e" runat="server" GroupName="p2" Text="e.- Pide parámetros de configuración" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label6" runat="server" Text="6- ¿Definición de IIS?"></asp:Label>
                <asp:Image ID="Image6" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel6" runat="server">   
                    <asp:CheckBox ID="p6a" runat="server" Text="a.- Servidor DNS de Microsoft que corre sobre una plataforma Windows" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p6b" runat="server" Text="b.- Servidor Web de Microsoft que corre sobre una plataforma Windows" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p6c" runat="server" Text="c.- Servidor Web de Microsoft que corre solo sobre una plataforma Solaris." AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p6d" runat="server" Text="d.- Informacion Informatica de Seguridad" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p6e" runat="server" Text="e.- Servicios de busqueda de informacion en la Web" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label7" runat="server" Text="7- ¿Qué servicios ofrece IIS?"></asp:Label>
                <asp:Image ID="Image7" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel7" runat="server">
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>a.- Servicios de busqueda de informacion en la Web</asp:ListItem>
                        <asp:ListItem>b.- Servicios de UDP</asp:ListItem>
                        <asp:ListItem>c.- Servicios FTP, SMTP, NNTP Y HTTP/HTTPS</asp:ListItem>
                        <asp:ListItem>d.- Servicios de monitoreo de trafico de red</asp:ListItem>
                        <asp:ListItem>e.- Servicios de encriptado</asp:ListItem>
                    </asp:DropDownList><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label8" runat="server" Text="8- ¿Qué significan las siglas HTTP?"></asp:Label>
                <asp:Image ID="Image8" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel8" runat="server">
                    <asp:RadioButton ID="p8a" runat="server" GroupName="p3" Text="a.- Hight Text Transfer Protocol" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p8b" runat="server" GroupName="p3" Text="b.- Hiden Text Trans Protocol" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p8c" runat="server" GroupName="p3" Text="c.- Hidetext Transfer Protocol" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p8d" runat="server" GroupName="p3" Text="d.- Hyper Transfer Text Protocol" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p8e" runat="server" GroupName="p3" Text="e.- Hypertext Transfer Protocol" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label9" runat="server" Text="9- ¿Sobre que conexión es transmitido HTTP?"></asp:Label>
                <asp:Image ID="Image9" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel9" runat="server">
                    <asp:CheckBox ID="p9a" runat="server" Text="a.- Sobre conexiones TCP" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p9b" runat="server" Text="b.- Sobre conexiones UDP" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p9c" runat="server" Text="c.- Sobre conexiones HTTPS" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p9d" runat="server" Text="d.- Sobre conexiones SSH" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p9e" runat="server" Text="e.- Sobre conexiones IP" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label10" runat="server" Text="10- ¿Donde se encuentran los HTML Forms?"></asp:Label>
                <asp:Image ID="Image10" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel10" runat="server">
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>a.-En el corazón de toda aplicación Web genuina.</asp:ListItem>
                        <asp:ListItem>b.- En la cabecera de toda aplicación Web genuina.</asp:ListItem>
                        <asp:ListItem>c.- En la cola de toda aplicación Web genuina.</asp:ListItem>
                        <asp:ListItem>d.- En los servidores donde se almacena la pagina Web</asp:ListItem>
                        <asp:ListItem>e.- En el localhost</asp:ListItem>
                    </asp:DropDownList><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label11" runat="server" Text="11- ¿Qué es un HTML Form?"></asp:Label>
                <asp:Image ID="Image11" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel11" runat="server">
                    <asp:RadioButton ID="p11a" runat="server" GroupName="p4" Text="a.- Es un contenedor de objetos HTML" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p11b" runat="server" GroupName="p4" Text="b.- Es todo el documento HTML" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p11c" runat="server" GroupName="p4" Text="c.- Es la parte final del un documento HTML" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p11d" runat="server" GroupName="p4" Text="d.- Es la porción de un documento HTML" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p11e" runat="server" GroupName="p4" Text="e.- HiperText Markup Language" AutoPostBack="true"/><br />
                    <br/>
                </asp:Panel>
                <asp:Label ID="Label12" runat="server" Text="12- ¿Cuál de estas siglas es una tecnología de procesamiento?"></asp:Label>
                <asp:Image ID="Image12" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel12" runat="server">
                    <asp:CheckBox ID="p12a" runat="server" Text="a.- CGI" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p12b" runat="server" Text="b.- ISAPI" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p12c" runat="server" Text="c.- ASP" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p12d" runat="server" Text="d.- TP" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p12e" runat="server" Text="e.- ITIL" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label13" runat="server" Text="13- ¿Cuál de estas son ventajas de ASP.NET?"></asp:Label>
                <asp:Image ID="Image13" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel13" runat="server">
                    <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>a.- Soporta XML, hojas de estilo CSS, etc.</asp:ListItem>
                        <asp:ListItem>b.- No permite usar ADO.NET para acceso a datos lo cual evita errores.</asp:ListItem>
                        <asp:ListItem>c.- Acceso a toda la .NET CLASS LIBRARY</asp:ListItem>
                        <asp:ListItem>d.- Uso de archivos CSS</asp:ListItem>
                        <asp:ListItem>e.- Carga mas rapida en navegador</asp:ListItem>
                    </asp:DropDownList><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label14" runat="server" Text="14- ¿Cuál de estos son componentes de una aplicación ASP.NET?"></asp:Label>
                <asp:Image ID="Image14" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel14" runat="server">
                    <asp:RadioButton ID="p14a" runat="server" GroupName="p4" Text="a.- Code-Hide" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p14b" runat="server" GroupName="p4" Text="b.- Global.asax" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p14c" runat="server" GroupName="p4" Text="c.- Es la parte final del un documento HTML" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p14d" runat="server" GroupName="p4" Text="d.- WebForms" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p14e" runat="server" GroupName="p4" Text="e.- WebForms Anidada a Pagina Maestra" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label15" runat="server" Text="15- ¿Qué son los archivos Code-Behind?"></asp:Label>
                <asp:Image ID="Image15" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel15" runat="server">
                    <asp:CheckBox ID="p15a" runat="server" Text="a.- Archivos multiples" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p15b" runat="server" Text="b.- Archivos asociados a WebForms" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p15c" runat="server" Text="c.- Archivos asociados a todas las aplicaciones Web" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p15d" runat="server" Text="d.- Archivos ocultos de codigo" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p15e" runat="server" Text="e.- Archivos ocultos de los WebForms" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label16" runat="server" Text="16- ¿Qué significan las siglas IIS?"></asp:Label>
                <asp:Image ID="Image16" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel16" runat="server">
                    <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="true">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>a.- Identification Information Server</asp:ListItem>
                        <asp:ListItem>b.- Internet Implementation Server</asp:ListItem>
                        <asp:ListItem>c.- Identity Institut Security</asp:ListItem>
                        <asp:ListItem>d.- Internet Information Server</asp:ListItem>
                        <asp:ListItem>e.- Internet Identity Server</asp:ListItem>
                    </asp:DropDownList><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label17" runat="server" Text="17- ¿Qué es un formulario Web?"></asp:Label>
                <asp:Image ID="Image17" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel17" runat="server">
                    <asp:RadioButton ID="p17a" runat="server" GroupName="p5" Text="a.- Es una página expresada en lenguaje de marcas" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p17b" runat="server" GroupName="p5" Text="b.- Es una .docx expresada en lenguaje de marcas" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p17c" runat="server" GroupName="p5" Text="c.- Es una página de códigos PHP" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p17d" runat="server" GroupName="p5" Text="d.- Es un documento realizado en DreamWeaver" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p17e" runat="server" GroupName="p5" Text="e.- Contenedor de WindowsForm" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label18" runat="server" Text="18- ¿Donde es compilada la WebForms?"></asp:Label>
                <asp:Image ID="Image18" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel18" runat="server">
                    <asp:CheckBox ID="p18a" runat="server" Text="a.- En cualquier navegador" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p18b" runat="server" Text="b.- En el servidor" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p18c" runat="server" Text="c.- En cualquier sistema" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p18d" runat="server" Text="d.- En el procesador" AutoPostBack="true"/><br />
                    <asp:CheckBox ID="p18e" runat="server" Text="e.- En Mozilla FireFox" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label19" runat="server" Text="19- ¿Qué es un controlador de Servicios?"></asp:Label>
                <asp:Image ID="Image19" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel19" runat="server">
                    <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="true">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>a.- Son componentes que se ejecutan al momento de conectar un dispositivo HW.</asp:ListItem>
                        <asp:ListItem>b.- Son componentes que se ejecutan del lado del Cliente.</asp:ListItem>
                        <asp:ListItem>c.- Son componentes que se ejecutan del lado del Usuario.</asp:ListItem>
                        <asp:ListItem>d.- Son componentes que se ejecutan del lado del Servidor.</asp:ListItem>
                        <asp:ListItem>e.- Son componentes que se ejecutan al hacer una llamada al sistema</asp:ListItem>
                    </asp:DropDownList><br />
                    <br />
                </asp:Panel>
                <asp:Label ID="Label20" runat="server" Text="20- ¿Cuál de estos es un evento de un Web Forms?"></asp:Label>
                <asp:Image ID="Image20" runat="server" CssClass="calificacion"/><br /><br />
                <asp:Panel ID="Panel20" runat="server">
                    <asp:RadioButton ID="p20a" runat="server" GroupName="p6" Text="a.- Post Back" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p20b" runat="server" GroupName="p6" Text="b.- IIS" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p20c" runat="server" GroupName="p6" Text="c.- View State" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p20d" runat="server" GroupName="p6" Text="d.- Front End" AutoPostBack="true"/><br />
                    <asp:RadioButton ID="p20e" runat="server" GroupName="p6" Text="e.- FeedBack" AutoPostBack="true"/><br />
                    <br />
                </asp:Panel>
            </div>
        </div>
        <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label27" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label25" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
