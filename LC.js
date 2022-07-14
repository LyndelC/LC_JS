/*Lyndel Conway
This code enables the user to change the language of the title and introduction from English to Spanish (questionable),
draw selected images on the canvas, select their colours, then complete the registration form and submit their entry.
*/
    
//EventListeners

//document.querySelector('#english').addEventListener("click", english());
document.querySelector('#spanish').addEventListener("click", spanish());  
document.querySelector("#clear").addEventListener("click", clear);
document.querySelector("#draw").addEventListener("click", draw);
document.querySelector("#confpassword").addEventListener("change", validate);

var canvas = document.querySelector("#yourCanvas");
var ctx = canvas.getContext("2d");


//function english(){
    //var engDiv = document.querySelector("#eng")
    //document.getElementById("#english")
    //pEng = true
    //hEng = true
     
    //if engDiv.innerHTML != true
    //{
    //        ("#english").innerHTML = (#Engdiv);
   // }   
    //else {
    //"engDiv";style.display = 'block';
//}
  //}

function spanish() {
    document.querySelector("hEng").innerHTML = "Concurso de Arte Abstracto";
    document.querySelector("pEng").innerHTML = "Dibuja tu obra de arte en el cuadro de abajo.<br> Cuando esté satisfecho con su dibujo, seleccione 'Save image' en el Menú de dibujo.<br> Adjunte su obra maestra seleccionando 'Adjuntar imagen', complete sus datos y luego envíe su formulario.<br>¡¡Buena suerte!!";
  }
    "#spanish";style.display = 'block';


function draw() {

  if (document.querySelector("#shape").value == "circle") {

    ctx.beginPath();
    ctx.arc(document.querySelector("#xstart").value, document.querySelector("#ystart").value, document.querySelector("#radius").value, 0, 2 * Math.PI);
    ctx.strokeStyle = "black";
    ctx.fillStyle = document.querySelector("#fillPalette").value; 
    ctx.fill();
    ctx.stroke();
  }

  else if (document.querySelector("#shape").value == "quadrilateral") {
      
    ctx.beginPath();
    ctx.fillStyle = (document.querySelector("#fillPalette").value); 
    ctx.fillRect(document.querySelector("#xstart").value, document.querySelector("#ystart").value, document.querySelector("#xend").value, document.querySelector("#yend").value); 
  }

    else if (document.querySelector("#shape").value =="line") {
      
        ctx.beginPath();
        ctx.moveTo(document.querySelector("#xstart").value, document.querySelector("#ystart").value);
        ctx.lineTo(document.querySelector("#xend").value, document.querySelector("#yend").value);
        ctx.lineWidth = 5;
        ctx.strokeStyle = document.querySelector("#linePalette").value;
        ctx.stroke();
    }
}

function clear() {  
    ctx.fillStyle = "white";
    ctx.fillRect(0, 0, 400, 400);   
}


    function validate(){
      if(document.querySelector("#password").value != document.querySelector("#confpassword").value) {
        document.querySelector("#confpassword").setCustomValidity("Passwords Don't Match");
        document.querySelector("#confpassword").reportValidity();
        document.querySelector("#password").value ='';
        document.querySelector("#confpassword").value ='';
      } 
      else {
        document.querySelector("#confpassword").setCustomValidity('');
        document.querySelector("#confpassword").reportValidity();
      } 
    }
    
