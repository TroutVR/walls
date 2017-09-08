<?php
	$serverName = "localhost";
	$serverUserName = "root";//"id2060806_test123";
	$serverPassword = "";//"123456";
	$dbName = "Item_Inventory";//"id2060806_database123";

	$userName = $_POST["usernamePost"];//"Hello World";
	$email = $_POST["emailPost"];//"Test Email";
	$password = $_POST["passwordPost"];//"123456";
	// Make Connection
	$conn = new mysqli($serverName, $serverUserName, $serverPassword, $dbName);
	// Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}

	$sql = "INSERT INTO users (userName, email, password)
		VALUES ('".$userName."','".$email."','".$password."')";
	$result = mysqli_query($conn,$sql);
	
	if(!$result)
		echo "there was an error";
	else 
		echo "Everything ok.";
?>