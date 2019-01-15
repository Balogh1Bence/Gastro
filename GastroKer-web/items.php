
<!DOCTYPE html>
	<html lang = "hu">
		<head>
			<meta charset = "utf-8" name="viewport" content="width=device-width, initial-scale=1.0">
			<title></title>
			<link rel = "stylesheet" href ="https://www.w3schools.com/w3css/4/w3.css">
			<link rel = "stylesheet" href ="w3style.css">
		</head>
		
		<body>
				<nav class = "w3-bar w3-red" id="bar">
				<div class = "w3-bar-item w3-button w3-mobile">Főoldal</div>
					<div class = "w3-bar-item w3-button w3-mobile">Belépés</div>
					<div class = "w3-bar-item w3-button w3-mobile">Regisztráció</div>
					<div class = "w3-bar-item w3-button w3-mobile">Kapcsolat</div>
					
				<div class="w3-bar-item w3-mobile"><input type="text" id="myInput" onkeyup="myFunction()" placeholder=" Search for names.." title="Type in a name"></div>
				</nav>
	
						<?php
				
$server="127.0.0.1";
$usname="root";
$pw="";
$dbname="gastro";
$conn=mysqli_connect($server,$usname,$pw,$dbname);
$conn -> set_charset("utf8");
$sql = "select Tnev from termekek";
$result = $conn -> query($sql);
echo "<div id = 'tartalom'>";
echo "<br>";
echo "<br>";
echo "<br>";
while ($row = $result -> fetch_assoc()){
		
		echo "<ul id='myUL'>";
		echo "<li><a href='#'>".$row['Tnev']."</a></li>";
		echo "</ul>";
	}
echo "</div>"


?>
		</body>
		<script>
function myFunction() {
    var input, filter, ul, li, a, i;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    ul = document.getElementById("myUL");
    li = ul.getElementsByTagName("li");
    for (i = 0; i < li.length; i++) {
        a = li[i].getElementsByTagName("a")[0];
        if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
			
        } else {
            li[i].style.display = "none";
        }
    }
}
</script>
	</html>
	