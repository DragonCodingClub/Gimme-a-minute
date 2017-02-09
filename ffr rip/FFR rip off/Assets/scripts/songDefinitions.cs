enum Direction
{
	LEFT_ARROW,
	RIGHT_ARROW,
	UP_ARROW,
	DOWN_ARROW	

}
interface Note
{


	Direction getObject();
	long getMillisFromStart();



}
interface Song
{
	Note [] getNotes();
}

class NoteImpl : Note

{
	Direction _dir;
	long _noteTime;
	public NoteImpl (Direction dir, long noteTime)
	{
		_dir = dir;
		_noteTime = noteTime;
	}
	public Direction getObject()
	{
		return _dir;
	}
	public long getMillisFromStart()
	{
		return _noteTime;
	}
}
class SongImpl : Song
{
	
	Note [] internalNotes = new Note [] {new NoteImpl(Direction.LEFT_ARROW, 500)
										, new NoteImpl(Direction.LEFT_ARROW, 1000)
										, new NoteImpl(Direction.LEFT_ARROW, 1200)
										, new NoteImpl(Direction.LEFT_ARROW, 1400)};
	public Note []	getNotes()
	{
		return internalNotes;
	}
}