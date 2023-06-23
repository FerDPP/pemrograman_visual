# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="violet")
app.geometry("300x250")
app.resizable(False,False)
app.title("Ferdy Pradana Putra")

# Function Rumus Belah Ketupat
def hitung():
    i_diag1 = float(i_diag1_entry.get())
    i_diag2 = float(i_diag2_entry.get())
    i_sisi = float(i_sisi_entry.get())
    
    luas = 0.5 * i_diag1 * i_diag2
    keliling = 4 * i_sisi
    
    showinfo("Ferdy Pradana Putra", "\nLuas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
i_diag1_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Belah Ketupat")
i_diag1_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label i_diag1
i_diag1_label = ttk.Label(input_frame, text="Masukkan diagonal 1 :")
i_diag1_label.pack(padx=10, fill="x", expand=True)
# 2. Entry i_diag1
i_diag1_entry = ttk.Entry(input_frame)
i_diag1_entry.pack(padx=10, fill="x", expand=True)
# 3. Label i_diag2
i_diag2_label = ttk.Label(input_frame, text="Masukkan diagonal 2 :")
i_diag2_label.pack(padx=10, fill="x", expand=True)
# 4. Entry i_diag2
i_diag2_entry = ttk.Entry(input_frame)
i_diag2_entry.pack(padx=10, fill="x", expand=True)
# 5. Label i_sisi
i_sisi_label = ttk.Label(input_frame, text="Masukkan sisi :")
i_sisi_label.pack(padx=10, fill="x", expand=True)
# 6. Entry i_sisi
i_sisi_entry = ttk.Entry(input_frame)
i_sisi_entry.pack(padx=10, fill="x", expand=True)
# 7. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

