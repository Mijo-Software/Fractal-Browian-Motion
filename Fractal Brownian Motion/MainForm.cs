using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal_Brownian_Motion
{
  public partial class MainForm : Form
  {
    private Graphics g;
    private readonly Pen p = new Pen(color: Color.Black);
    private readonly SolidBrush b = new SolidBrush(color: Color.Black);

    public MainForm() => InitializeComponent();

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
      RadioboxMovementOwned_CheckChanged(sender: sender, e: e);
      rbDistanceConstant.Checked = true;
      numDistanceConstant.Value = 1;
      RadioboxDistanceConstant_CheckedChanged(sender: sender, e: e);
      numDistanceVariableMin.Value = 1;
      numDistanceVariableMax.Value = 10;
      RadioboxDistanceVariable_CheckedChanged(sender: sender, e: e);
      CheckboxPauseEnabled_CheckChanged(sender: sender, e: e);
      btnStop.Enabled = false;
    }

    private void ButtonStart_Click(object sender, EventArgs e)
    {
      btnStart.Enabled = false;
      btnStop.Enabled = true;
      if (picView.Visible)
      {
        picView.Visible = false;
      }
      g = CreateGraphics();
      b.Color = Color.White;
      g.FillRectangle(brush: b, x: picView.Left, y: picView.Top, width: picView.Width, height: picView.Height);
      p.Color = Color.Black;
      g.DrawRectangle(pen: p, x: picView.Left, y: picView.Top, width: picView.Width, height: picView.Height);
      b.Color = Color.Black;
      //g.FillRectangle(b, pictureBoxOverlay.Left, pictureBoxOverlay.Top, pictureBoxOverlay.Width, pictureBoxOverlay.Height);
      p.Color = Color.Black;
      //g.DrawRectangle(p, pictureBoxOverlay.Left, pictureBoxOverlay.Top, pictureBoxOverlay.Width, pictureBoxOverlay.Height);

      g.FillEllipse(b, picView.Width, picView.Height / 2, 1, 2);
      Random rnd = new Random();
      for (int i = 0; i < 50; i++)
      {
            case (rnd.Next(1, 9))
                s


        }



      g.Dispose();
    }

    private void ButtonStop_Click(object sender, EventArgs e)
    {
      btnStart.Enabled = true;
      btnStop.Enabled = false;
    }

    private void ButtonPencolor_Click(object sender, EventArgs e)
    {
      using (ColorDialog cd = new ColorDialog())
      {
        if (cd.ShowDialog() == DialogResult.OK)
        {
          btnPencolor.ForeColor = cd.Color;
        }
      }
    }

    private void ButtonBackgroundcolor_Click(object sender, EventArgs e)
    {
      using (ColorDialog cd = new ColorDialog())
      {
        if (cd.ShowDialog() == DialogResult.OK)
        {
          btnBackgroundcolor.BackColor = cd.Color;
        }
      }
    }

    private void CheckboxMovementOwnedNW_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckboxMovementOwnedN_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckboxMovementOwnedNE_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckboxMovementOwnedW_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckboxMovementOwnedC_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckboxMovementOwnedE_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckboxMovementOwnedSW_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckboxMovementOwnedS_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void CheckboxMovementOwnedSE_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void RadioboxMovementOwned_CheckChanged(object sender, EventArgs e)
    {
      if (rbMovementOwned.Checked)
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

    private void RadioboxDistanceConstant_CheckedChanged(object sender, EventArgs e) => numDistanceConstant.Enabled = rbDistanceConstant.Checked;

    private void RadioboxDistanceVariable_CheckedChanged(object sender, EventArgs e)
    {
      if (rbDistanceVariable.Checked)
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

    private void CheckboxPauseEnabled_CheckChanged(object sender, EventArgs e) => numPauseLength.Enabled = cbPauseEnabled.Checked;
  }
}
