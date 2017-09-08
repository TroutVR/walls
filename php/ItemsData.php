<?php
	$serverName = "localhost";
	$userName = "root";
	$password = "";
	$dbName = "Item_Inventory";

	// Make Connection
	$conn = new mysqli($serverName, $userName, $password, $dbName);
	// Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}

	// $sql = "SELECT id, name, prefabName, idParent, active, xPosition, yPosition, zPosition,
	//		 xRotation, yRotation, zRotation, xScale, yScale, zScale FROM items";
			
	 $sql = "SELECT id, itemName, itemPrefabName, idParent, active, position, rotation, localScale FROM 123wmarket" ;
	
	$result = mysqli_query($conn,$sql);
	
	if(mysqli_num_rows($result) > 0){
		// Show data for each row.
		while($row = mysqli_fetch_assoc($result)){
			// echo "ID:".$row['id'] . "|name:".$row['name']. "|prefabName:".$row['prefabName']
			// . "|idParent:".$row['idParent']. "|active:".$row['active']. "|xPosition:".$row['xPosition']
			// . "|yPosition:".$row['yPosition'] . "|zPosition:".$row['zPosition'] . "|xRotation:".$row['xRotation'] 
			// . "|yRotation:".$row['yRotation'] . "|zRotation:".$row['zRotation'] . "|xScale:".$row['xScale'] 
			// . "|yScale:".$row['yScale'] . "|zScale:".$row['zScale'] .   ";";
			
		//	echo $row['id'] . "|".$row['name']. "|".$row['prefabName']
		//	. "|".$row['idParent']. "|".$row['active']. "|".$row['xPosition']
		//	. "|".$row['yPosition'] . "|".$row['zPosition'] . "|".$row['xRotation'] 
		//	. "|".$row['yRotation'] . "|".$row['zRotation'] . "|".$row['xScale'] 
		//	. "|".$row['yScale'] . "|".$row['zScale'];
			
						 echo $row['id'] . "|".$row['itemName']. "|".$row['itemPrefabName']
			 . "|".$row['idParent']. "|".$row['active']. "|".$row['position']
			 . "|".$row['rotation'] . "|".$row['localScale'];
		}
	}
	
	
?>