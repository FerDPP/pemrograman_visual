from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W
class FrmTrapesium:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x400")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
# pasang Label
        Label(mainFrame, text="Alas a:").grid(row=0, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Alas b:").grid(row=1, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi:").grid(row=2, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi a:").grid(row=3, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi b:").grid(row=4, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi c:").grid(row=5, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi d:").grid(row=6, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=8, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=9, column=0,
        sticky=W, padx=5, pady=5)
# pasang textbox
        self.txtAlas1 = Entry(mainFrame)
        self.txtAlas1.grid(row=0, column=1, padx=5, pady=5)
        self.txtAlas2 = Entry(mainFrame)
        self.txtAlas2.grid(row=1, column=1, padx=5, pady=5)
        self.txtTinggi = Entry(mainFrame)
        self.txtTinggi.grid(row=2, column=1, padx=5, pady=5)
        self.txtSisi1 = Entry(mainFrame)
        self.txtSisi1.grid(row=3, column=1, padx=5, pady=5)
        self.txtSisi2 = Entry(mainFrame)
        self.txtSisi2.grid(row=4, column=1, padx=5, pady=5)
        self.txtSisi3 = Entry(mainFrame)
        self.txtSisi3.grid(row=5, column=1, padx=5, pady=5)
        self.txtSisi4 = Entry(mainFrame)
        self.txtSisi4.grid(row=6, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=8, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=9, column=1, padx=5, pady=5)
# Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
        command=self.onHitung)
        self.btnHitung.grid(row=7, column=1, padx=5, pady=5)
# fungsi untuk menghitung luas dan keliling persegi panjang
    def onHitung(self, event=None):
 # perhitungan dengan metode Pemrograman Tidak Terstruktur
        i_alas1 = int(self.txtAlas1.get())
        i_alas2 = int(self.txtAlas2.get())
        i_tinggi = int(self.txtTinggi.get())
        i_sisi1 = int(self.txtSisi1.get())
        i_sisi2 = int(self.txtSisi2.get())
        i_sisi3 = int(self.txtSisi3.get())
        i_sisi4 = int(self.txtSisi4.get())
        luas = 1/2 * (i_alas1 * i_alas2) * i_tinggi
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        kel = i_sisi1 + i_sisi2 + i_sisi3 + i_sisi4
        self.txtKeliling.delete(0,END)
        self.txtKeliling.insert(END,str(kel))
    def onKeluar(self, event=None):
# memberikan perintah menutup aplikasi
        self.parent.destroy()
if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmTrapesium(root, "Program Luas dan Keliling Trapesium")
    root.mainloop()