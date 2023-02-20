# DraftingPathSample

3D 캐드 기반의 기본적인 Entity 생성 / 수정 / 삭제 등을 할 수 있는 샘플코드 입니다. Visual studio 2022 에서 작업하였으며, 프로젝트 내부 DraftingPathComponentDLL 폴더에 필요 DLL이 있습니다.

- Summury 코드
```CSharp
public partial class Form1 : Form
    {
        DraftingViewport viewport = null;
        
        //...

        private void Form1_Load(object sender, EventArgs e)
        {
            viewport = new DraftingViewport();
            viewport.Dock = DockStyle.Fill;
            panel1.Controls.Add(viewport);

            propertyGrid1.SelectedObject = viewport;

            viewport.EntiesSelectionChange += Viewport_EntiesSelectionChange;
        }

        private void Viewport_EntiesSelectionChange(object sender, EventArgs e)
        {
            List<int> selection = sender as List<int>;
            if (selection != null && selection.Count > 0)
            {
                int selInd = selection[0];

                propertyGrid2.SelectedObject = viewport.GetEditEntity(selInd);
            }
            else
            {
                propertyGrid2.SelectedObject = null;
            }
        }
        
        //...
    }
```

문의 사항은 https://luciodev.tistory.com/ 의 방명록에 남겨주세요~!
