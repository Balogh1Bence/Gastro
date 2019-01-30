<?php
    
    if (isset($_SESSION['uid'])){
        header('Location: index.php');
        die();
    } else {
        $menu = file_get_contents('../html/menu_out.html');
    }
    $regForm = file_get_contents("../html/reg_form.html");
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Regisztráció</title>
        <link rel="stylesheet" type="text/css" href="../css/style.css">
    </head>
    <body>
        <nav>
            <?php echo $menu; ?>
        </nav>
        <?php
            echo $regForm;
        ?>
    </body>
</html>
