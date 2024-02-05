namespace renamer;

class FileName
{
    private string? _path { get; }
    private string? _name { get; set; }
    private string? _NewName { get; set; }
    private string? _tempName { get; set; }
        

    public FileName(string path)
    {
        _path = Path.GetDirectoryName(path);
        _name = Path.GetFileName(path);
        _NewName = _name;
        _tempName = _name;
    }

    public string name()
    {
        return _name;
    }

    public string newName()
    {
        return _NewName;
    }

    public string tempName()
    {
        return _tempName;
    }
        
    public string path()
    {
        return _path;
    }
        
    public string getFullPath()
    {
        return $"{_path}\\{_name}";
    }
        
    public string getFullNewPath()
    {
        return $"{_path}\\{_NewName}";
    }
        
    public void Replace(string from, string to)
    {
        _NewName = _NewName.Replace(from, to);
    }
        
    public void GetExpect(string from, string to)
    {
        _tempName = _NewName.Replace(from, to);
    }

    public bool IsUpdate()
    {
        return _name != _NewName;
    }
    
    public bool IsColorUpdate()
    {
        return (_name != _NewName) || (_NewName != _tempName);
    }

    public void ApplyTempName()
    {
        if (_tempName != _NewName) _NewName = _tempName;
    }
    
    public void Update()
    {
        _name = _NewName;
        _tempName = _NewName;
    }
}