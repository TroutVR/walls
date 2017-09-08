<?php
	$serverName = "localhost";
	$userName = "id2060806_test123";
	$password = "123456";
	$dbName = "id2060806_database123";

	$user_username = $_POST["usernamePost"];
	$user_password = $_POST["passwordPost"];
	// Make Connection
	$conn = new mysqli($serverName, $userName, $password, $dbName);
	// Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}

	$sql = "SELECT password FROM users WHERE userName = '".$user_username."'";
	$result = mysqli_query($conn,$sql);
	
	// Get the result and confirm login.
	if(mysqli_num_rows($result) > 0){
		// Show data for each row.
		while($row = mysqli_fetch_assoc($result)){
			if($row['password'] == $user_password){
				echo "login success";
			}else {
				echo "password incorrect";
			}
		}
	}else{
		echo "user not found";
	}
	
	
?>