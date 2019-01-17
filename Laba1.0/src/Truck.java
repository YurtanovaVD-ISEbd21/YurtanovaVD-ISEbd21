import java.awt.Color;
import java.awt.Graphics;


public class Truck extends TruckAbstract{
	
	protected final int carWidth = 100;/// Øèðèíà îòðèñîâêè àâòîìîáèëÿ
    protected final int carHeight = 60;/// Øèðèíà îòðèñîâêè àâòîìîáèëÿ

    public Truck(int maxSpeed, float weight, Color mainColor) /// Êîíñòðóêòîð
    {
        MaxSpeed = maxSpeed;
        Weight = weight;
        MainColor = mainColor;
    }
	@Override
	public void MoveTransport(Direction direction) {
		float step = getMaxSpeed() * 100 / getWeight();
		switch (direction)
		{
			// âïðàâî
			case Right:
				if (_startPosX + step < _pictureWidth - carWidth)
				{
					_startPosX += step;
				}
				break;
			//âëåâî
			case Left:
				if (_startPosX - step > 0)
				{
					_startPosX -= step;
				}
				break;
			//ââåðõ
			case Up:
				if (_startPosY - step > 0)
				{
					_startPosY -= step;
				}
				break;
			//âíèç
			case Down:
				if (_startPosY + step < _pictureHeight - carHeight)
				{
					_startPosY += step;
				}
				break;
		}
	}
	@Override
	public void DrawTruckTrailer(Graphics g) {
		 g.setColor(Color.ORANGE);
         g.fillRect( (int)_startPosX + 60, (int)_startPosY + 0, 30, 30);
         g.fillRect((int) _startPosX + 30, (int)_startPosY + 15, 30, 15);
         g.fillRect( (int)_startPosX + 60,(int) _startPosY - 10, 30, 10);
         g.setColor(Color.BLUE);
         g.fillRect( (int)_startPosX + 70, (int)_startPosY + 0, 20, 20);
      
         g.setColor(Color.BLACK);
         g.fillOval( (int)_startPosX + 30,(int) _startPosY + 30, 15, 15);
         g.fillOval( (int)_startPosX + 50, (int)_startPosY + 30, 15, 15);
         g.fillOval( (int)_startPosX + 75,(int) _startPosY + 30, 15, 15);
         
        
         
	}
}