using System;
using System.Windows.Forms;

namespace AppManageTool
{
    class OpaqueCommand
    {
        private MyOpaqueLayer m_OpaqueLayer = null;//��͸���ɰ��

        /// <summary>
        /// ��ʾ���ֲ�
        /// </summary>
        /// <param name="control">�ؼ�</param>
        /// <param name="alpha">͸���� ���Ϊ255 </param>
        /// <param name="isShowLoadingImage">�Ƿ���ʾͼ��</param>
        public void ShowOpaqueLayer(Control control, int alpha, bool isShowLoadingImage)
        {
            try
            {
                if (this.m_OpaqueLayer == null)
                {
                    this.m_OpaqueLayer = new MyOpaqueLayer(alpha, isShowLoadingImage);
                    control.Controls.Add(this.m_OpaqueLayer);
                    control.Controls.SetChildIndex(this.m_OpaqueLayer, 0);
                    this.m_OpaqueLayer.Dock = DockStyle.Fill;
                    this.m_OpaqueLayer.BringToFront();
                }
                this.m_OpaqueLayer.Enabled = true;
                this.m_OpaqueLayer.Visible = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// �������ֲ�
        /// </summary>
        public void HideOpaqueLayer()
        {
            try
            {
                if (this.m_OpaqueLayer != null)
                {
                    this.m_OpaqueLayer.Visible = false;
                    this.m_OpaqueLayer.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
