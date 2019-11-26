using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fractal_Brownian_Motion
{
  public partial class MainApp : Form
  {

      Graphics g;
      Pen p = new Pen(Color.Black);
      SolidBrush b = new SolidBrush(Color.Black);

    public MainApp()
    {
      InitializeComponent();
    }

    private void MainApp_Load(object sender, EventArgs e)
    {
      rbMovementMooreNeumann.Checked = true;
      cbMovementOwnedNW.Checked = true;
      cbMovementOwnedN.Checked = true;
      cbMovementOwnedNE.Checked = true;
      cbMovementOwnedW.Checked = true;
      cbMovementOwnedC.Checked = true;
      cbMovementOwnedE.Checked = true;
      cbMovementOwnedSW.Checked = true;
      cbMovementOwnedS.Checked = true;
      cbMovementOwnedSE.Checked = true;

      rbMovementOwned_CheckChanged(sender,e);

      rbDistanceConstant.Checked = true;
      numDistanceConstant.Value = 1;
      rbDistanceConstant_CheckedChanged(sender, e);

      numDistanceVariableMin.Value = 1;
      numDistanceVariableMax.Value = 10;
      rbDistanceVariable_CheckedChanged(sender, e);

      cbPauseEnabled_CheckChanged(sender, e);

      btnStop.Enabled = false;
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        btnStart.Enabled = false;
        btnStop.Enabled = true;

        if (picView.Visible) picView.Visible = false;

        g = CreateGraphics();
        b.Color = Color.White;
        g.FillRectangle(b, picView.Left, picView.Top, picView.Width, picView.Height);
        p.Color = Color.Black;
        g.DrawRectangle(p, picView.Left, picView.Top, picView.Width, picView.Height);
        b.Color = Color.Black;
        //g.FillRectangle(b, pictureBoxOverlay.Left, pictureBoxOverlay.Top, pictureBoxOverlay.Width, pictureBoxOverlay.Height);
        p.Color = Color.Black;
        //g.DrawRectangle(p, pictureBoxOverlay.Left, pictureBoxOverlay.Top, pictureBoxOverlay.Width, pictureBoxOverlay.Height);

        g.FillEllipse(b, picView.Width, picView.Height/2, 1, 2);
        Random rnd = new Random();
        for (int i = 0;i < 50; i++)
        {
            case (rnd.Next(1, 9))
                s
            
        }



            g.Dispose();
    }
    private void btnStop_Click(object sender, EventArgs e)
    {
      btnStart.Enabled = true;
      btnStop.Enabled = false;

    }

    private void btnPencolor_Click(object sender, EventArgs e)
    {
      ColorDialog cd = new ColorDialog();
      if (cd.ShowDialog() == DialogResult.OK)
        btnPencolor.ForeColor = cd.Color;
    }

    private void btnBackgroundcolor_Click(object sender, EventArgs e)
    {
      ColorDialog cd = new ColorDialog();
      if (cd.ShowDialog() == DialogResult.OK)
        btnBackgroundcolor.BackColor = cd.Color;
    }

    private void cbMovementOwnedNW_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbMovementOwnedN_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbMovementOwnedNE_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbMovementOwnedW_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbMovementOwnedC_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbMovementOwnedE_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbMovementOwnedSW_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbMovementOwnedS_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void cbMovementOwnedSE_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void rbMovementOwned_CheckChanged(object sender, EventArgs e)
    {
      if (rbMovementOwned.Checked == true)
      {
        cbMovementOwnedNW.Enabled = true;
        cbMovementOwnedN.Enabled = true;
        cbMovementOwnedNE.Enabled = true;
        cbMovementOwnedW.Enabled = true;
        cbMovementOwnedC.Enabled = true;
        cbMovementOwnedE.Enabled = true;
        cbMovementOwnedSW.Enabled = true;
        cbMovementOwnedS.Enabled = true;
        cbMovementOwnedSE.Enabled = true;
      }
      else
      {
        cbMovementOwnedNW.Enabled = false;
        cbMovementOwnedN.Enabled = false;
        cbMovementOwnedNE.Enabled = false;
        cbMovementOwnedW.Enabled = false;
        cbMovementOwnedC.Enabled = false;
        cbMovementOwnedE.Enabled = false;
        cbMovementOwnedSW.Enabled = false;
        cbMovementOwnedS.Enabled = false;
        cbMovementOwnedSE.Enabled = false;
      }
    }

    private void rbDistanceConstant_CheckedChanged(object sender, EventArgs e)
    {
      if (rbDistanceConstant.Checked == true)
        numDistanceConstant.Enabled = true;
      else numDistanceConstant.Enabled = false;
    }

    private void rbDistanceVariable_CheckedChanged(object sender, EventArgs e)
    {
      if (rbDistanceVariable.Checked == true)
      {
        numDistanceVariableMin.Enabled = true;
        numDistanceVariableMax.Enabled = true;
      }
      else
      {
        numDistanceVariableMin.Enabled = false;
        numDistanceVariableMax.Enabled = false;
      }
    }

    private void cbPauseEnabled_CheckChanged(object sender, EventArgs e)
    {
      if (cbPauseEnabled.Checked == true)
        numPauseLength.Enabled = true;
      else numPauseLength.Enabled = false;
    }
  }
}
