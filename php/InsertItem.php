<?php
	$serverName = "localhost";
	$serverUserName = "root";//"id2060806_test123";
	$serverPassword = "";//"123456";
	$dbName = "Item_Inventory";//"id2060806_database123";

	$itemName = $_POST["itemNamePost"];
	$itemPrefabName = $_POST["itemPrefabNamePost"];
	$idParent = $_POST["idParentPost"];
	$active = $_POST["activePost"];
	$position = $_POST["positionPost"];
	$localScale = $_POST["localScalePost"];
	$rotation = $_POST["rotationPost"];
	
	// Make Connection
	$conn = new mysqli($serverName, $serverUserName, $serverPassword, $dbName);
	// Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}

	$sql = "INSERT INTO 123wmarket(1) (itemName, itemPrefabName, idParent, active, position, localScale, rotation)
		SELECT ('".$itemName."','".$itemPrefabName."','".$idParent."','".$active ."','".$position ."','".$localScale ."','".$rotation ."') 
		WHERE not exists (select 1 from 123wmarket where itemName = ".$itemName;
	$result = mysqli_query($conn,$sql);
	
	print $itemName;
	
	if(!$result)
		echo "there was an error";
	else 
		echo "Everything ok.";
?>