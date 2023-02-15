using System;
using System.Collections.Generic;

/// <summary>
/// 어떤 노래가 어떤 노트들로 이루어져 있는지에 대한 데이터
/// </summary>
[Serializable]
public class SongData
{
    public string name;
    public List<NoteData> notes;
}
