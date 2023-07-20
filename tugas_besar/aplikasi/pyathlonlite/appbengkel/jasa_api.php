<?php
require_once 'database.php';
require_once 'Jasa.php';
$db = new MySQLDatabase();
$jasa = new Jasa($db);
$id=0;
$koja=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['koja'])){
            $koja = $_GET['koja'];
        }
        if($id>0){    
            $result = $jasa->get_by_id($id);
        }elseif($koja>0){
            $result = $jasa->get_by_koja($koja);
        } else {
            $result = $jasa->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new Jasa
        $jasa->koja = $_POST['koja'];
        $jasa->nama = $_POST['nama'];
        $jasa->jk = $_POST['jk'];
        $jasa->najas = $_POST['najas'];
        $jasa->harga = $_POST['harga'];
       
        $jasa->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Jasa created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Jasa not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['koja'])){
            $koja = $_GET['koja'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $jasa->koja = $_PUT['koja'];
        $jasa->nama = $_PUT['nama'];
        $jasa->jk = $_PUT['jk'];
        $jasa->najas = $_PUT['najas'];
        $jasa->harga = $_PUT['harga'];

        if($id>0){    
            $jasa->update($id);
        }elseif($koja<>""){
            $jasa->update_by_koja($koja);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Jasa updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Jasa update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['koja'])){
            $koja = $_GET['koja'];
        }
        if($id>0){    
            $jasa->delete($id);
        }elseif($koja>0){
            $jasa->delete_by_koja($koja);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Jasa deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Jasa delete failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
    }
$db->close()
?>