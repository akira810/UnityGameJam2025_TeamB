using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class BackGroundMover : MonoBehaviour
{
    private const float k_maxLength = 1f;
    private const string k_propName = "_MainTex";

    [SerializeField]
    private Vector2 m_offsetSpeed;
    //�w�i�̐ݒ�
    private Material m_copiedMaterial;

    private void Start()
    {
        var image = GetComponent<Image>();
        m_copiedMaterial = new Material(image.material);
        image.material = m_copiedMaterial;

        // �}�e���A����null���������O���o�܂��B
        Assert.IsNotNull(m_copiedMaterial);
    }

    private void Update()
    {
        if (Time.timeScale == 0f)
        {
            return;
        }

        // x��y�̒l��0 �` 1�Ń��s�[�g����悤�ɂ���
        var x = Mathf.Repeat(Time.time * m_offsetSpeed.x, k_maxLength);
        var y = Mathf.Repeat(Time.time * m_offsetSpeed.y, k_maxLength);
        var offset = new Vector2(x, y);
        m_copiedMaterial.SetTextureOffset(k_propName, offset);
    }

    private void OnDestroy()
    {
        // �Q�[���I�u�W�F�N�g�j�󎞂Ƀ}�e���A���̃R�s�[�������Ă���
        if (m_copiedMaterial != null)
        {
            Destroy(m_copiedMaterial);
        }
        m_copiedMaterial = null;
    }
}