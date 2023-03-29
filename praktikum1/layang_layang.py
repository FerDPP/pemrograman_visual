# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="violet")
app.geometry("300x370")
app.resizable(False,False)
app.title("Ferdy Pradana Putra")

# Function Rumus Layang - Layang
def hitung():
    i_diag1 = float(i_diag1_entry.get())
    i_diag2 = float(i_diag2_entry.get())
    i_sisi1 = float(i_sisi1_entry.get())
    i_sisi2 = float(i_sisi2_entry.get())
    i_sisi3 = float(i_sisi3_entry.get())
    i_sisi4 = float(i_sisi4_entry.get())
    
    luas = (i_diag1 * i_diag2) / 2
    keliling = i_sisi1 + i_sisi2 + i_sisi3 + i_sisi4
    
    showinfo("Ferdy Pradana Putra", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
i_diag1_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Layang - Layang")
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
# 5. Label i_sisi1
i_sisi1_label = ttk.Label(input_frame, text="Masukkan sisi 1 :")
i_sisi1_label.pack(padx=10, fill="x", expand=True)
# 6. Entry i_sisi1
i_sisi1_entry = ttk.Entry(input_frame)
i_sisi1_entry.pack(padx=10, fill="x", expand=True)
# 7. Label i_sisi2
i_sisi2_label = ttk.Label(input_frame, text="Masukkan sisi 2 :")
i_sisi2_label.pack(padx=10, fill="x", expand=True)
# 8. Entry i_sisi2
i_sisi2_entry = ttk.Entry(input_frame)
i_sisi2_entry.pack(padx=10, fill="x", expand=True)
# 9. Label i_sisi3
i_sisi3_label = ttk.Label(input_frame, text="Masukkan sisi 3 :")
i_sisi3_label.pack(padx=10, fill="x", expand=True)
# 10. Entry i_sisi3
i_sisi3_entry = ttk.Entry(input_frame)
i_sisi3_entry.pack(padx=10, fill="x", expand=True)
# 11. Label i_sisi4
i_sisi4_label = ttk.Label(input_frame, text="Masukkan sisi 4 :")
i_sisi4_label.pack(padx=10, fill="x", expand=True)
# 12. Entry i_sisi4
i_sisi4_entry = ttk.Entry(input_frame)
i_sisi4_entry.pack(padx=10, fill="x", expand=True)
# 13. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

