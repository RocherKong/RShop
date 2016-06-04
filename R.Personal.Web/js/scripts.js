$(document).ready(function() {

	// Smooth Scroll to internal links

	$(".scroll").click(function(event){		
			event.preventDefault();
			
			$scroll = $(this.hash).offset().top;
			$scroll = $scroll - 90;
			$('html,body').animate({scrollTop:$scroll}, 500);
		});

	
	// Turn scrolling events off for iOS devices
	var iOS = false,
    p = navigator.platform;

	if( p === 'iPad' || p === 'iPhone' || p === 'iPod' ){
		iOS = true;
	}


	// Scroll effect on Home Page photo
	if(iOS == false){
		var div = $('#home-photo');
				$(window).on('scroll', function() {
				   var st = $(this).scrollTop();
				   div.css({ 'bottom' : (st*1.5) });
				   div.css({ 'right' : ((st*2)) });
				   var srotate = "rotate(" + ((st/1.8)) + "deg)";
				   $("#home-photo").css({"-moz-transform" : srotate, "-webkit-transform" : srotate});
				});
	}
	
	
	//Contact Form Code:
	$(function (e) {
		$("#contact-form .form-button").click(function (e) {
			var $error = 0;
			var name = $("#form-name").val();
			var email = $("#form-email").val();
			var text = $("#form-msg").val();
			var security = $("#form-security").val();
			
			if(name == "" || email=="" || text=="" ){
				$('#details-error-wrap').fadeIn(1000);
				$error = 1;
				
			}else{
				$('#details-error-wrap').fadeOut(1000);
			}
			
			if(security != "8"){
				$('#security-error-wrap').fadeIn(1000);
				$error = 1;
			}
			
			if(security == "8"){
				$('#security-error-wrap').fadeOut(1000);
			}

			
			var dataString = 'name=' + name + '&email=' + email + '&text=' + text;
			
			if($error == 0){
				$.ajax({
					type: "POST",
					url: "mail.php",
					data: dataString,
					success: function () {
						$('#details-error-wrap').fadeOut(1000);
						$('#security-error-wrap').fadeOut(1000);
						$('#form-sent').fadeIn(1000);
					}
				});
				return false;
			}
			
			e.preventDefault();
		});
	});
	

	// Handle hover event for the project images

	$(".project-img-wrap").mouseenter(function(){
			$(this).children('.project-hover').fadeIn(200);
		}).mouseleave(function(){
		  $(this).children('.project-hover').fadeOut(200);
		});	
	
	//Tooltips Code:
	 $('.hasatip').tooltipster({
	 	delay: 0,
	 	speed: 100,
	 	touchDevices: false
	 });

});