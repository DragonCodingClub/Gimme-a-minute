interface Song
{
	interface Note
		{
			enum Direction
			{
				LEFT_ARROW,
				RIGHT_ARROW,
				UP_ARROW,
				DOWN_ARROW			
			}

			Direction getObject();
			long getMillisFromStart();



		}

		Note [] getNotes(long startTime, long endTime);

}

class NoteImpl : Song.Note

{
	Direction _dir;
	long _noteTime;
	NoteImpl (Direction dir, long noteTime)
	{}
}
class SongImpl : Song
{
	Notes [] internalNotes = [new NoteImpl(LEFT_ARROW, 500), new NoteImpl(RIGHT_ARROW, 1000)]
	getNotes(long startTime, long endTime)
	{
 
	}
}