# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="violet")
app.geometry("300x170")
app.resizable(False,False)
app.title("Ferdy Pradana Putra")

# Function Rumus Lingkaran
def hitung():
    i_jari = float(i_jari_entry.get())
    
    luas = 22/7 * i_jari ** 2
    keliling = 2 * 22/7 * i_jari
    
   
    
    showinfo("Ferdy Pradana Putra", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
i_jari_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Lingkaran")
i_jari_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label i_jari
i_jari_label = ttk.Label(input_frame, text="Masukkan Jari Jari :")
i_jari_label.pack(padx=10, fill="x", expand=True)
# 2. Entry i_jari
i_jari_entry = ttk.Entry(input_frame)
i_jari_entry.pack(padx=10, fill="x", expand=True)
# 3. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

