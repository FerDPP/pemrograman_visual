<?php
require_once 'database.php';
require_once 'Pelanggan.php';
$db = new MySQLDatabase();
$pelanggan = new Pelanggan($db);
$id=0;
$noa=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['noa'])){
            $noa = $_GET['noa'];
        }
        if($id>0){    
            $result = $pelanggan->get_by_id($id);
        }elseif($noa>0){
            $result = $pelanggan->get_by_noa($noa);
        } else {
            $result = $pelanggan->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new Pelanggan    
        $pelanggan->noa = $_POST['noa'];
        $pelanggan->nama = $_POST['nama'];
        $pelanggan->jk = $_POST['jk'];
        $pelanggan->tgl_datang = date('Y-m-d', strtotime($_POST['tgl_datang']));
        $pelanggan->alamat = $_POST['alamat'];
        $pelanggan->kota =$_POST['kota'];
        $pelanggan->jeken = $_POST['jeken'];
        $pelanggan->merk = $_POST['merk'];
        $pelanggan->plat = $_POST['plat'];
        $pelanggan->kode_jasa = $_POST['kode_jasa'];
        $pelanggan->hajas = $_POST['hajas'];
        
        $pelanggan->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pelanggan created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pelanggan not created.';
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
        if(isset($_GET['noa'])){
            $noa = $_GET['noa'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $pelanggan->noa = $_PUT['noa'];
        $pelanggan->nama = $_PUT['nama'];
        $pelanggan->jk = $_PUT['jk'];
        $pelanggan->tgl_datang = date('Y-m-d', strtotime($_PUT['tgl_datang']));
        $pelanggan->alamat = $_PUT['alamat'];
        $pelanggan->kota =$_PUT['kota'];
        $pelanggan->jeken = $_PUT['jeken'];
        $pelanggan->merk = $_PUT['merk'];
        $pelanggan->plat = $_PUT['plat'];
        $pelanggan->kode_jasa = $_PUT['kode_jasa'];
        $pelanggan->hajas = $_PUT['hajas'];
        
        if($id>0){    
            $pelanggan->update($id);
        }elseif($noa<>""){
            $pelanggan->update_by_noa($noa);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pelanggan updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pelanggan update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['noa'])){
            $noa = $_GET['noa'];
        }
        if($id>0){    
            $pelanggan->delete($id);
        }elseif($noa>0){
            $pelanggan->delete_by_noa($noa);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pelanggan deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pelanggan delete failed.';
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