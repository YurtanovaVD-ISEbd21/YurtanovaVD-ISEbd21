import java.awt.Color;
import java.awt.Graphics;


public class TruckTrailer extends Truck {

	public Color DopColor;// Äîïîëíèòåëüíûé öâåò

	public Color getDopColor() {
		return DopColor;
	}

	public void setDopColor(Color value) {
		DopColor = value;
	}

	private boolean Tilt;// Ïðèçíàê íàëè÷èÿ êàáèíû

	public boolean getCabin() {
		return Tilt;
	}

	public void setTilt(boolean value) {
		Tilt = value;
	}

	public TruckTrailer(int maxSpeed, float weight, Color mainColor,
			Color dopColor, boolean tilt) {
		super(maxSpeed, weight, mainColor);
		DopColor = dopColor;
		Tilt = tilt;
	}

	@Override
	public void DrawTruckTrailer(Graphics g)// Îòðèñîâêà àâòîìîáèëÿ
	{
		super.DrawTruckTrailer(g);
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
         g.fillRect( (int)_startPosX + 30, (int)_startPosY + 5, 30, 10);
        
       
	}
}