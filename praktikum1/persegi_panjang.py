# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="violet")
app.geometry("300x200")
app.resizable(False,False)
app.title("Ferdy Pradana Putra")

# Function Rumus Persegi i_panjang
def hitung():
    i_panjang = float(i_panjang_entry.get())
    i_lebar = float(i_lebar_entry.get())
    
    luas = i_panjang * i_lebar
    keliling = 2 * (i_panjang + i_lebar)
    
    showinfo("Ferdy Pradana Putra", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
i_panjang_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Persegi Panjang")
i_panjang_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label i_panjang
i_panjang_label = ttk.Label(input_frame, text="Masukkan Panjang :")
i_panjang_label.pack(padx=10, fill="x", expand=True)
# 2. Entry i_panjang
i_panjang_entry = ttk.Entry(input_frame)
i_panjang_entry.pack(padx=10, fill="x", expand=True)
# 3. Label i_lebar
i_lebar_label = ttk.Label(input_frame, text="Masukkan Lebar :")
i_lebar_label.pack(padx=10, fill="x", expand=True)
# 4. Entry i_lebar
i_lebar_entry = ttk.Entry(input_frame)
i_lebar_entry.pack(padx=10, fill="x", expand=True)
# 5. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

