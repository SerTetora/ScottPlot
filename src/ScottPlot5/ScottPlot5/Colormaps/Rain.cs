//This is a cmocean colormap
//All credit to Kristen Thyng
//This colormap is under the MIT License
//All cmocean colormaps are available at https://github.com/matplotlib/cmocean/tree/master/cmocean/rgb

namespace ScottPlot.Colormaps;

public class Rain : IColormap
{
    public string Name => "Rain";
    readonly CustomPalette Colormap;
    public Color GetColor(double position) => Colormap.GetColor(position);
    public Rain()
    {
        Color[] colors =
        [
            new( 238, 237, 243 ),
            new( 238, 236, 241 ),
            new( 237, 235, 240 ),
            new( 236, 234, 238 ),
            new( 235, 233, 236 ),
            new( 235, 232, 235 ),
            new( 234, 231, 233 ),
            new( 233, 230, 232 ),
            new( 232, 229, 230 ),
            new( 232, 228, 229 ),
            new( 231, 227, 227 ),
            new( 230, 226, 226 ),
            new( 229, 225, 224 ),
            new( 228, 223, 223 ),
            new( 228, 222, 221 ),
            new( 227, 221, 220 ),
            new( 227, 220, 218 ),
            new( 226, 219, 216 ),
            new( 226, 218, 214 ),
            new( 225, 217, 212 ),
            new( 224, 216, 211 ),
            new( 224, 215, 209 ),
            new( 223, 214, 207 ),
            new( 223, 213, 205 ),
            new( 222, 212, 203 ),
            new( 222, 211, 201 ),
            new( 221, 209, 199 ),
            new( 221, 208, 197 ),
            new( 220, 207, 195 ),
            new( 220, 206, 193 ),
            new( 219, 205, 191 ),
            new( 219, 204, 190 ),
            new( 219, 203, 188 ),
            new( 218, 202, 186 ),
            new( 218, 201, 184 ),
            new( 217, 200, 182 ),
            new( 216, 199, 180 ),
            new( 216, 198, 178 ),
            new( 215, 197, 176 ),
            new( 215, 196, 174 ),
            new( 214, 195, 172 ),
            new( 213, 194, 170 ),
            new( 213, 193, 168 ),
            new( 212, 192, 166 ),
            new( 211, 191, 164 ),
            new( 210, 191, 162 ),
            new( 209, 190, 160 ),
            new( 208, 189, 158 ),
            new( 207, 188, 156 ),
            new( 205, 188, 155 ),
            new( 204, 187, 153 ),
            new( 203, 186, 152 ),
            new( 201, 186, 150 ),
            new( 200, 185, 149 ),
            new( 198, 185, 148 ),
            new( 196, 184, 146 ),
            new( 195, 183, 145 ),
            new( 193, 183, 144 ),
            new( 192, 182, 143 ),
            new( 190, 182, 142 ),
            new( 188, 181, 141 ),
            new( 186, 181, 141 ),
            new( 185, 180, 140 ),
            new( 183, 179, 139 ),
            new( 181, 179, 138 ),
            new( 180, 178, 137 ),
            new( 178, 178, 137 ),
            new( 176, 177, 136 ),
            new( 174, 177, 135 ),
            new( 173, 176, 135 ),
            new( 171, 176, 134 ),
            new( 169, 175, 133 ),
            new( 168, 174, 133 ),
            new( 166, 174, 132 ),
            new( 164, 173, 132 ),
            new( 162, 173, 131 ),
            new( 161, 172, 130 ),
            new( 159, 172, 130 ),
            new( 157, 171, 129 ),
            new( 156, 170, 129 ),
            new( 154, 170, 128 ),
            new( 152, 169, 128 ),
            new( 150, 169, 127 ),
            new( 149, 168, 126 ),
            new( 147, 168, 126 ),
            new( 145, 167, 125 ),
            new( 144, 167, 125 ),
            new( 142, 166, 124 ),
            new( 140, 165, 124 ),
            new( 138, 165, 123 ),
            new( 137, 164, 123 ),
            new( 135, 164, 122 ),
            new( 133, 163, 122 ),
            new( 131, 163, 121 ),
            new( 130, 162, 120 ),
            new( 128, 161, 120 ),
            new( 126, 161, 119 ),
            new( 124, 160, 119 ),
            new( 122, 160, 118 ),
            new( 121, 159, 118 ),
            new( 119, 159, 117 ),
            new( 117, 158, 117 ),
            new( 115, 157, 117 ),
            new( 113, 157, 116 ),
            new( 111, 156, 116 ),
            new( 109, 156, 115 ),
            new( 107, 155, 115 ),
            new( 105, 155, 114 ),
            new( 103, 154, 114 ),
            new( 101, 154, 114 ),
            new( 100, 153, 113 ),
            new( 97, 152, 113 ),
            new( 95, 152, 113 ),
            new( 93, 151, 112 ),
            new( 91, 151, 112 ),
            new( 89, 150, 112 ),
            new( 87, 149, 111 ),
            new( 85, 149, 111 ),
            new( 83, 148, 111 ),
            new( 81, 148, 111 ),
            new( 79, 147, 110 ),
            new( 76, 147, 110 ),
            new( 74, 146, 110 ),
            new( 72, 145, 110 ),
            new( 70, 145, 110 ),
            new( 67, 144, 110 ),
            new( 65, 143, 110 ),
            new( 63, 143, 110 ),
            new( 61, 142, 110 ),
            new( 58, 141, 109 ),
            new( 56, 141, 109 ),
            new( 54, 140, 109 ),
            new( 52, 139, 109 ),
            new( 49, 139, 110 ),
            new( 47, 138, 110 ),
            new( 45, 137, 110 ),
            new( 43, 137, 110 ),
            new( 41, 136, 110 ),
            new( 38, 135, 110 ),
            new( 36, 134, 110 ),
            new( 34, 134, 110 ),
            new( 32, 133, 110 ),
            new( 30, 132, 110 ),
            new( 28, 131, 110 ),
            new( 27, 130, 110 ),
            new( 25, 129, 110 ),
            new( 23, 129, 110 ),
            new( 21, 128, 110 ),
            new( 20, 127, 110 ),
            new( 18, 126, 110 ),
            new( 17, 125, 110 ),
            new( 15, 124, 110 ),
            new( 14, 124, 110 ),
            new( 12, 123, 110 ),
            new( 11, 122, 110 ),
            new( 10, 121, 110 ),
            new( 9, 120, 110 ),
            new( 8, 119, 110 ),
            new( 7, 118, 110 ),
            new( 6, 117, 110 ),
            new( 6, 116, 110 ),
            new( 5, 116, 110 ),
            new( 5, 115, 110 ),
            new( 4, 114, 110 ),
            new( 4, 113, 110 ),
            new( 4, 112, 109 ),
            new( 3, 111, 109 ),
            new( 3, 110, 109 ),
            new( 3, 109, 109 ),
            new( 3, 108, 109 ),
            new( 4, 107, 109 ),
            new( 4, 107, 109 ),
            new( 4, 106, 108 ),
            new( 4, 105, 108 ),
            new( 5, 104, 108 ),
            new( 5, 103, 108 ),
            new( 6, 102, 108 ),
            new( 7, 101, 107 ),
            new( 7, 100, 107 ),
            new( 8, 99, 107 ),
            new( 9, 98, 107 ),
            new( 10, 97, 106 ),
            new( 11, 96, 106 ),
            new( 12, 95, 106 ),
            new( 13, 95, 105 ),
            new( 14, 94, 105 ),
            new( 15, 93, 105 ),
            new( 16, 92, 104 ),
            new( 17, 91, 104 ),
            new( 18, 90, 103 ),
            new( 19, 89, 103 ),
            new( 20, 88, 103 ),
            new( 21, 87, 102 ),
            new( 22, 86, 102 ),
            new( 22, 85, 101 ),
            new( 23, 84, 101 ),
            new( 24, 83, 100 ),
            new( 25, 82, 100 ),
            new( 26, 81, 99 ),
            new( 26, 80, 99 ),
            new( 27, 79, 98 ),
            new( 28, 78, 97 ),
            new( 28, 77, 97 ),
            new( 29, 76, 96 ),
            new( 30, 75, 95 ),
            new( 30, 74, 95 ),
            new( 31, 73, 94 ),
            new( 31, 72, 93 ),
            new( 32, 72, 93 ),
            new( 33, 71, 92 ),
            new( 33, 70, 91 ),
            new( 33, 69, 90 ),
            new( 34, 68, 90 ),
            new( 34, 67, 89 ),
            new( 35, 66, 88 ),
            new( 35, 65, 87 ),
            new( 35, 64, 86 ),
            new( 36, 63, 86 ),
            new( 36, 62, 85 ),
            new( 36, 61, 84 ),
            new( 36, 60, 83 ),
            new( 36, 59, 82 ),
            new( 37, 58, 81 ),
            new( 37, 57, 81 ),
            new( 37, 56, 80 ),
            new( 37, 55, 79 ),
            new( 37, 55, 78 ),
            new( 37, 54, 77 ),
            new( 37, 53, 76 ),
            new( 37, 52, 76 ),
            new( 37, 51, 75 ),
            new( 37, 50, 74 ),
            new( 37, 49, 73 ),
            new( 37, 48, 72 ),
            new( 37, 47, 72 ),
            new( 37, 46, 71 ),
            new( 37, 45, 70 ),
            new( 37, 44, 69 ),
            new( 37, 43, 69 ),
            new( 37, 42, 68 ),
            new( 36, 41, 67 ),
            new( 36, 40, 66 ),
            new( 36, 39, 66 ),
            new( 36, 39, 65 ),
            new( 36, 38, 64 ),
            new( 36, 37, 63 ),
            new( 35, 36, 63 ),
            new( 35, 35, 62 ),
            new( 35, 34, 61 ),
            new( 35, 33, 61 ),
            new( 35, 32, 60 ),
            new( 34, 31, 59 ),
            new( 34, 30, 58 ),
            new( 34, 29, 58 ),
            new( 34, 28, 57 ),
            new( 34, 27, 56 ),
        ];

        Colormap = new CustomPalette(colors);
    }
}

