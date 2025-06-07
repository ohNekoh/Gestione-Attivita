<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GBListe = New GroupBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtPercentuale = New TextBox()
        txtAttivitàDaFare = New TextBox()
        txtAttivitàCompletate = New TextBox()
        txtAttivitàTotali = New TextBox()
        lstStato = New ListBox()
        lstData = New ListBox()
        lstDescrizione = New ListBox()
        lstNome = New ListBox()
        GBComandi = New GroupBox()
        btnEsci = New Button()
        btnImpostaStato = New Button()
        btnContaData = New Button()
        btnCercaData = New Button()
        btnVisualizza = New Button()
        btnCerca = New Button()
        btnSostituisci = New Button()
        btnElimina = New Button()
        btnAggiungi = New Button()
        btnInserisci = New Button()
        GBListe.SuspendLayout()
        GBComandi.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBListe
        ' 
        GBListe.Controls.Add(Label8)
        GBListe.Controls.Add(Label7)
        GBListe.Controls.Add(Label6)
        GBListe.Controls.Add(Label5)
        GBListe.Controls.Add(Label4)
        GBListe.Controls.Add(Label3)
        GBListe.Controls.Add(Label2)
        GBListe.Controls.Add(Label1)
        GBListe.Controls.Add(txtPercentuale)
        GBListe.Controls.Add(txtAttivitàDaFare)
        GBListe.Controls.Add(txtAttivitàCompletate)
        GBListe.Controls.Add(txtAttivitàTotali)
        GBListe.Controls.Add(lstStato)
        GBListe.Controls.Add(lstData)
        GBListe.Controls.Add(lstDescrizione)
        GBListe.Controls.Add(lstNome)
        GBListe.Location = New Point(58, 50)
        GBListe.Name = "GBListe"
        GBListe.Size = New Size(735, 547)
        GBListe.TabIndex = 0
        GBListe.TabStop = False
        GBListe.Text = "Dati"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(567, 490)
        Label8.Name = "Label8"
        Label8.Size = New Size(121, 15)
        Label8.TabIndex = 15
        Label8.Text = "% Attività completate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(384, 490)
        Label7.Name = "Label7"
        Label7.Size = New Size(132, 15)
        Label7.TabIndex = 14
        Label7.Text = "Attività non completate"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(230, 490)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 15)
        Label6.TabIndex = 13
        Label6.Text = "Attività completate"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(65, 490)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 15)
        Label5.TabIndex = 12
        Label5.Text = "Attività totali"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(538, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 11
        Label4.Text = "Stato"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(402, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 10
        Label3.Text = "Data"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(165, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 9
        Label2.Text = "Descrizione"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 8
        Label1.Text = "Nome"
        ' 
        ' txtPercentuale
        ' 
        txtPercentuale.Location = New Point(558, 508)
        txtPercentuale.Name = "txtPercentuale"
        txtPercentuale.PlaceholderText = "Vuoto"
        txtPercentuale.ReadOnly = True
        txtPercentuale.Size = New Size(139, 23)
        txtPercentuale.TabIndex = 7
        txtPercentuale.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtAttivitàDaFare
        ' 
        txtAttivitàDaFare.Location = New Point(384, 508)
        txtAttivitàDaFare.Name = "txtAttivitàDaFare"
        txtAttivitàDaFare.PlaceholderText = "Vuoto"
        txtAttivitàDaFare.ReadOnly = True
        txtAttivitàDaFare.Size = New Size(139, 23)
        txtAttivitàDaFare.TabIndex = 6
        txtAttivitàDaFare.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtAttivitàCompletate
        ' 
        txtAttivitàCompletate.Location = New Point(214, 508)
        txtAttivitàCompletate.Name = "txtAttivitàCompletate"
        txtAttivitàCompletate.PlaceholderText = "Vuoto"
        txtAttivitàCompletate.ReadOnly = True
        txtAttivitàCompletate.Size = New Size(139, 23)
        txtAttivitàCompletate.TabIndex = 5
        txtAttivitàCompletate.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtAttivitàTotali
        ' 
        txtAttivitàTotali.Location = New Point(32, 508)
        txtAttivitàTotali.Name = "txtAttivitàTotali"
        txtAttivitàTotali.PlaceholderText = "Vuoto"
        txtAttivitàTotali.ReadOnly = True
        txtAttivitàTotali.Size = New Size(139, 23)
        txtAttivitàTotali.TabIndex = 4
        txtAttivitàTotali.TextAlign = HorizontalAlignment.Center
        ' 
        ' lstStato
        ' 
        lstStato.FormattingEnabled = True
        lstStato.ItemHeight = 15
        lstStato.Location = New Point(538, 52)
        lstStato.Name = "lstStato"
        lstStato.Size = New Size(159, 409)
        lstStato.TabIndex = 3
        ' 
        ' lstData
        ' 
        lstData.FormattingEnabled = True
        lstData.ItemHeight = 15
        lstData.Location = New Point(402, 52)
        lstData.Name = "lstData"
        lstData.Size = New Size(139, 409)
        lstData.TabIndex = 2
        ' 
        ' lstDescrizione
        ' 
        lstDescrizione.FormattingEnabled = True
        lstDescrizione.ItemHeight = 15
        lstDescrizione.Location = New Point(165, 52)
        lstDescrizione.Name = "lstDescrizione"
        lstDescrizione.Size = New Size(241, 409)
        lstDescrizione.TabIndex = 1
        ' 
        ' lstNome
        ' 
        lstNome.FormattingEnabled = True
        lstNome.ItemHeight = 15
        lstNome.Location = New Point(32, 52)
        lstNome.Name = "lstNome"
        lstNome.Size = New Size(139, 409)
        lstNome.TabIndex = 0
        ' 
        ' GBComandi
        ' 
        GBComandi.Controls.Add(btnEsci)
        GBComandi.Controls.Add(btnImpostaStato)
        GBComandi.Controls.Add(btnContaData)
        GBComandi.Controls.Add(btnCercaData)
        GBComandi.Controls.Add(btnVisualizza)
        GBComandi.Controls.Add(btnCerca)
        GBComandi.Controls.Add(btnSostituisci)
        GBComandi.Controls.Add(btnElimina)
        GBComandi.Controls.Add(btnAggiungi)
        GBComandi.Controls.Add(btnInserisci)
        GBComandi.Location = New Point(799, 50)
        GBComandi.Name = "GBComandi"
        GBComandi.Size = New Size(474, 492)
        GBComandi.TabIndex = 1
        GBComandi.TabStop = False
        GBComandi.Text = "Comandi"
        ' 
        ' btnEsci
        ' 
        btnEsci.Location = New Point(269, 409)
        btnEsci.Name = "btnEsci"
        btnEsci.Size = New Size(181, 66)
        btnEsci.TabIndex = 9
        btnEsci.Text = "Esci dal programma"
        btnEsci.UseVisualStyleBackColor = True
        ' 
        ' btnImpostaStato
        ' 
        btnImpostaStato.Location = New Point(269, 320)
        btnImpostaStato.Name = "btnImpostaStato"
        btnImpostaStato.Size = New Size(181, 66)
        btnImpostaStato.TabIndex = 8
        btnImpostaStato.Text = "Imposta uno stato"
        btnImpostaStato.UseVisualStyleBackColor = True
        ' 
        ' btnContaData
        ' 
        btnContaData.Location = New Point(266, 233)
        btnContaData.Name = "btnContaData"
        btnContaData.Size = New Size(184, 66)
        btnContaData.TabIndex = 7
        btnContaData.Text = "Cerca quantità (per data)"
        btnContaData.UseVisualStyleBackColor = True
        ' 
        ' btnCercaData
        ' 
        btnCercaData.Location = New Point(266, 138)
        btnCercaData.Name = "btnCercaData"
        btnCercaData.Size = New Size(184, 66)
        btnCercaData.TabIndex = 6
        btnCercaData.Text = "Cerca (per data)"
        btnCercaData.UseVisualStyleBackColor = True
        ' 
        ' btnVisualizza
        ' 
        btnVisualizza.Location = New Point(269, 52)
        btnVisualizza.Name = "btnVisualizza"
        btnVisualizza.Size = New Size(181, 66)
        btnVisualizza.TabIndex = 5
        btnVisualizza.Text = "Visualizza"
        btnVisualizza.UseVisualStyleBackColor = True
        ' 
        ' btnCerca
        ' 
        btnCerca.Location = New Point(45, 409)
        btnCerca.Name = "btnCerca"
        btnCerca.Size = New Size(202, 66)
        btnCerca.TabIndex = 4
        btnCerca.Text = "Cerca (per descrizione)"
        btnCerca.UseVisualStyleBackColor = True
        ' 
        ' btnSostituisci
        ' 
        btnSostituisci.Location = New Point(45, 320)
        btnSostituisci.Name = "btnSostituisci"
        btnSostituisci.Size = New Size(202, 66)
        btnSostituisci.TabIndex = 3
        btnSostituisci.Text = "Sostituisci"
        btnSostituisci.UseVisualStyleBackColor = True
        ' 
        ' btnElimina
        ' 
        btnElimina.Location = New Point(45, 233)
        btnElimina.Name = "btnElimina"
        btnElimina.Size = New Size(202, 66)
        btnElimina.TabIndex = 2
        btnElimina.Text = "Elimina i dati"
        btnElimina.UseVisualStyleBackColor = True
        ' 
        ' btnAggiungi
        ' 
        btnAggiungi.Location = New Point(45, 138)
        btnAggiungi.Name = "btnAggiungi"
        btnAggiungi.Size = New Size(202, 66)
        btnAggiungi.TabIndex = 1
        btnAggiungi.Text = "Aggiungi"
        btnAggiungi.UseVisualStyleBackColor = True
        ' 
        ' btnInserisci
        ' 
        btnInserisci.Location = New Point(45, 52)
        btnInserisci.Name = "btnInserisci"
        btnInserisci.Size = New Size(202, 66)
        btnInserisci.TabIndex = 0
        btnInserisci.Text = "Inserisci"
        btnInserisci.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1285, 634)
        Controls.Add(GBComandi)
        Controls.Add(GBListe)
        Name = "Form1"
        Text = "Form1"
        GBListe.ResumeLayout(False)
        GBListe.PerformLayout()
        GBComandi.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBListe As GroupBox
    Friend WithEvents lstDescrizione As ListBox
    Friend WithEvents lstNome As ListBox
    Friend WithEvents GBComandi As GroupBox
    Friend WithEvents btnCerca As Button
    Friend WithEvents btnSostituisci As Button
    Friend WithEvents btnElimina As Button
    Friend WithEvents btnAggiungi As Button
    Friend WithEvents btnInserisci As Button
    Friend WithEvents btnVisualizza As Button
    Friend WithEvents lstData As ListBox
    Friend WithEvents btnCercaData As Button
    Friend WithEvents btnContaData As Button
    Friend WithEvents lstStato As ListBox
    Friend WithEvents btnImpostaStato As Button
    Friend WithEvents btnEsci As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPercentuale As TextBox
    Friend WithEvents txtAttivitàDaFare As TextBox
    Friend WithEvents txtAttivitàCompletate As TextBox
    Friend WithEvents txtAttivitàTotali As TextBox

End Class
