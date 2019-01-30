$(document).ready(function(){
	$("input").focus(function(){
	$(this).css("background-color", "yellow");
	});
	$("input").blur(function(){
	$(this).css("background-color", "white");
})});
$("#username").blur(function(){
	
		$("usernameError").html(checkusername($(this).val()));
	})
	$("#password").blur(function(){
	
		$("pwerror").html(checkpw($(this).val()));
	})
function checkusername(value){
	if(value.length<6) error+="tú rövid a felh";
	return error;
}
function checkpw(value){
	if(value.length<6) error+="tú rövid a jelsz";
	return error;
}