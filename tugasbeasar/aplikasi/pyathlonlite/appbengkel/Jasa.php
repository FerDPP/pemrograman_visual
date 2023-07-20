<?php
//Simpanlah dengan nama file : Jasa.php
require_once 'database.php';
class Jasa 
{
    private $db;
    private $table = 'jasa';
    public $koja = "";
    public $nama = "";
    public $jk = "";
    public $najas = "";
    public $harga = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    public function get_all() 
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function get_by_koja(int $koja)
    {
        $query = "SELECT * FROM $this->table WHERE koja = $koja";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`koja`,`nama`,`jk`,`najas`,`harga`) VALUES ('$this->koja','$this->nama','$this->jk','$this->najas','$this->harga')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET koja = '$this->koja', nama = '$this->nama', jk = '$this->jk', najas = '$this->najas', harga = '$this->harga' 
        WHERE idmk = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_koja($koja): int
    {
        $query = "UPDATE $this->table SET koja = '$this->koja', nama = '$this->nama', jk = '$this->jk', najas = '$this->najas', harga = '$this->harga' 
        WHERE koja = $koja";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE idmk = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_koja($koja): int
    {
        $query = "DELETE FROM $this->table WHERE koja = $koja";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>