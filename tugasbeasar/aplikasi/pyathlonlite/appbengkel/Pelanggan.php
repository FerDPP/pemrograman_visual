<?php
//Simpanlah dengan nama file : Pelanggan.php
require_once 'database.php';
class Pelanggan 
{
    private $db;
    private $table = 'pelanggan';
    public $noa = "";
    public $nama = "";
    public $jk = "";
    public $tgl_datang = "";
    public $alamat = "";
    public $kota = "";
    public $jeken = "";
    public $merk = "";
    public $plat = "";
    public $kode_jasa = "";
    public $hajas = "";
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
    public function get_by_noa(int $noa)
    {
        $query = "SELECT * FROM $this->table WHERE noa = $noa";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`noa`, `nama`, `jk`, `tgl_datang`, `alamat`, `kota`, `jeken`, `merk`, `plat`, `kode_jasa`, `hajas`) VALUES ('$this->noa', '$this->nama', '$this->jk', '$this->tgl_datang', '$this->alamat', '$this->kota', '$this->jeken', '$this->merk', '$this->plat', '$this->kode_jasa', '$this->hajas')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET noa = '$this->noa', nama = '$this->nama', jk = '$this->jk', tgl_datang = '$this->tgl_datang', alamat = '$this->alamat', kota = '$this->kota', jeken = '$this->jeken', merk = '$this->merk', plat = '$this->plat', kode_jasa = '$this->kode_jasa', hajas = '$this->hajas' WHERE idmk = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_noa($noa): int
    {
        $query = "UPDATE $this->table SET noa = '$this->noa', nama = '$this->nama', jk = '$this->jk', tgl_datang = '$this->tgl_datang', alamat = '$this->alamat', kota = '$this->kota', jeken = '$this->jeken', merk = '$this->merk', plat = '$this->plat', kode_jasa = '$this->kode_jasa', hajas = '$this->hajas' WHERE noa = '$noa'";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE idmk = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_noa($noa): int
    {
        $query = "DELETE FROM $this->table WHERE noa = $noa";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}